using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();    }
    Rigidbody2D rb;
    // Update is called once per frame
    void Update()
    {
        rb.angularVelocity = 100;
    }
}
