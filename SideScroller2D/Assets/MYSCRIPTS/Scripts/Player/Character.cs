using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using UnityEditor;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public SpriteRenderer sr;
    public Animator anim;
    public Rigidbody2D rig;
    public GameObject Bullet;
    public GameObject RestartButton;
    public Transform PositionRight;
    public Transform PositionLeft;
    public int Health;
    public int Speed;
    public float JumpForce;
    public float ShotSpeed;
    public float ShootTimer = .2f;
    bool ShotTimer;
    bool IsGrounded;
    private GameMaster GM;
    
    
    
    public static Character instance;
    public float InvincibleTimeAfterHurt;
    public Collider2D[] MyColls;
    
    


    public void Start()
    {   
        instance = this;
        MyColls = this.GetComponents<Collider2D>();
        ShotTimer = false;
        //RestartButton.SetActive(false);
        GM = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameMaster>();
    }

    void Update()
    {
        if (ShotTimer)
            ShootTimer -= Time.deltaTime;
        if (ShootTimer <= 0)
        {
            ShotTimer = false;
            anim.SetBool("IsShooting", false);
            ShootTimer = .2f;
        }

        Movement();
        if (IsGrounded) anim.SetBool("IsGrounded", true);
        else anim.SetBool("IsGrounded", false);
        //gravity adjusting the jump
        if (rig.velocity.y < 0)
        {
            rig.velocity += Vector2.up * Physics2D.gravity.y * 2 * Time.deltaTime;
        }

        if (Health <= 0)
        {
            Die();
        }
    }

    void Movement()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!ShotTimer)
            {
                if (!sr.flipX)
                {
                    GameObject newBullet = Instantiate(Bullet, PositionLeft.position, transform.rotation);
                    newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * ShotSpeed;
                }
                else
                {
                    GameObject newBullet = Instantiate(Bullet, PositionRight.position, transform.rotation);
                    newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * -ShotSpeed;   
                }
                anim.SetBool("IsShooting", true);
                ShotTimer = true;
            }
        }

            if (Input.GetKeyDown(KeyCode.W))
            {
                if (IsGrounded)
                {
                    rig.AddForce(Vector2.up * JumpForce);
                    anim.SetBool("IsShooting", false);
                    IsGrounded = false;
                }
            }

            if (Input.GetKey(KeyCode.D))
            {
                anim.SetBool("IsWalking", true);
                anim.SetBool("IsShooting", false);
                transform.Translate(new Vector3(Speed * Time.deltaTime, 0, 0));
                sr.flipX = false;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                anim.SetBool("IsWalking", true);
                anim.SetBool("IsShooting", false);
                transform.Translate(new Vector3(-Speed * Time.deltaTime, 0, 0));
                sr.flipX = true;
            }
            else anim.SetBool("IsWalking", false);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            IsGrounded = true;
            anim.SetBool("IsGrounded", true);
        }
        
        if (col.gameObject.tag.Equals("Enemy"))
        {
            RestartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }

    void Die()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Damage(int Dmg)
    {
        Health -= Dmg;
        gameObject.GetComponent<Animation>().Play("AlphaBlink");
    }

    public IEnumerator Knockback(float knockDurration, float knockbackPower, Vector3 knockbackDirection)
    {
        float timer = 0;
        rig.velocity = new Vector2(rig.velocity.x, 0);
        while (knockDurration > timer)
        {
            timer += Time.deltaTime;
            rig.AddForce(new Vector3(knockbackDirection.x * -5, knockbackDirection.y + knockbackPower,
                transform.position.z));
            
        }

        yield return 0;
    }
}