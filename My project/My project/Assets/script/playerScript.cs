using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    //플레이이어의 이동속도
    public float speed;
    //플레이어의 점프력
    public float jumpPower;
    //플레이어의 체력
    public int life = 100;
    public Rigidbody2D rb;
    public Transform respone;

    Animator animator;
    SpriteRenderer spriteRenderer;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        move();
        if(life<=0)
        {
            Destroy(this.gameObject);
        }

    }public bool Isfloor = false;

    const int std = 0;
    const int wlk = 1;
    const int atc = 4;
    private void move()
    {
        animator.SetInteger("state", std);
        if (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow))
        {
            animator.SetInteger("state", wlk);
            transform.Translate(-speed * Time.deltaTime, 0, 0);
            spriteRenderer.flipX = true;
        }
        if (Input.GetKey(KeyCode.D)|| Input.GetKey(KeyCode.RightArrow))
        {
            animator.SetInteger("state", wlk);
            transform.Translate(speed * Time.deltaTime, 0, 0);
            spriteRenderer.flipX = false;
        }
        if (Input.GetKeyDown(KeyCode.Space))//점프
        {
            if (Isfloor)
            {
                rb.velocity = new Vector3(0, jumpPower, 0);
            }
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("wall") is false)
        Isfloor = true;

        if (collision.transform.tag == "dead")
        {
            transform.position = respone.position;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        Isfloor = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "FallingStone")
        {
            life -= 1;
        }
        if (collision.tag == "dead")
        {
            transform.position = respone.position;
        }
    }
}
