using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scens : MonoBehaviour
{
    public GameObject Ejfdu;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print(1);
        if (collision .tag == "player")
        {
            print(2);
            Ejfdu.GetComponent<Rigidbody2D>().gravityScale = gravity;
        }

    }
}