using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    //�÷����̾��� �̵��ӵ�
    public float speed;
    //�÷��̾��� ������
    public float jumpPower;
    //�÷��̾��� ü��
    public Rigidbody2D rb;
    public Transform respone;

    Animator animator;
    SpriteRenderer spriteRenderer;
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        move();

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
        if (Input.GetKeyDown(KeyCode.Space))//����
        {
            if (Isfloor)
            {
                rb.velocity = new Vector3(0, jumpPower, 0);
                audioSource.Play();
            }
            
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("wall") is false)
        Isfloor = true;

        if (collision.transform.tag == "dead")
        {
            responing();
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
        }
        if (collision.tag == "dead")
        {
            responing();
        }
        if(collision.tag=="spon")
        {
            respone = collision.transform;
        }
    }
    void responing()
    {
        transform.position = respone.position;
    }
}
