using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dron : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Instantiate(Bullet);
        Bullet.GetComponent<bullet>().IsGuidedMissile = false;
    }
    bool IsPlayerOnRnge;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("palyer"))
        {
            IsPlayerOnRnge = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("palyer"))
        {
            IsPlayerOnRnge = false;
        }
    }
    public GameObject Bullet;

}
