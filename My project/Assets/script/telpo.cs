using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telpo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Transform �̵���ų��ǥ;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("player"))
        {
            collision.transform.position = �̵���ų��ǥ.position;
        }
    }
}