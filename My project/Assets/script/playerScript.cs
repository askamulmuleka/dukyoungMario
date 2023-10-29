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
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        move();
        if(life<=0)
        {
            Destroy(this.gameObject);
        }

    }public bool Isfloor = false;
    private void move()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.Space))//점프
        {
            if(Isfloor)
            {
                rb.velocity = new Vector3(0, jumpPower, 0);
            }
            
        }
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("wall") is false)
        Isfloor = true;
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
            Destroy(this.gameObject);
        }
    }
}
