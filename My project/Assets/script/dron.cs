using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class dron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public bool IsPlayerOnRange = false;
    public float bulletCoolTime = 2f;
    float timer = 0;
    public GameObject Bullet;
    // Update is called once per frame
    void Update()
    {
        if(IsPlayerOnRange is true)
        {
            timer += Time.deltaTime;
            if(timer > bulletCoolTime)
            {
                timer = 0;
                Instantiate(Bullet,transform.position,transform.rotation,transform);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            IsPlayerOnRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("player"))
        {
            IsPlayerOnRange = false;
        }
    }
}
