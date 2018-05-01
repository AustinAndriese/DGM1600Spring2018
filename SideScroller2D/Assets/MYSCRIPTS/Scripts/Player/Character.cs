using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters;
using UnityEditor;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int Speed = 10;
    public SpriteRenderer sr;
    public Animator anim;
    public float JumpForce;
    public Rigidbody2D rig;
    public bool IsGrounded;
    public int Health;
    public Transform PositionLeft;
    public Transform PositionRight;
    public GameObject Bullet;
    public float ShotSpeed;
    public bool ShotTimer;
    public float ShootTimer = .2f;


    void Start()
    {
        ShotTimer = false;
    }

    void Update()
    {
        if (ShotTimer = true)
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
        if (rig.velocity.y < 0)
        {
            rig.velocity += Vector2.up * Physics2D.gravity.y * 2 * Time.deltaTime;
        }
    }

    void Movement()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!ShotTimer)
            {
                if (!sr.flipX)
                {
                        GameObject newBullet = Instantiate(Bullet, PositionLeft.position, transform.rotation);
                        newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * -ShotSpeed;
                }
                else
                {
                    GameObject newBullet = Instantiate(Bullet, PositionRight.position, transform.rotation);
                    newBullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * ShotSpeed;   
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            IsGrounded = true;
            anim.SetBool("IsGrounded", true);
        }

    }
}