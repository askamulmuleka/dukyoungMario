using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class bukdollmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        end = start + new Vector3(xRange, yRange, 0);
    }
    private Vector3 start;
    private Vector3 end;

    public float speed;
    public float xRange;
    public float yRange;
    public bool goXend = true;
    public bool goYend = true;
    public bool 수직모드 = false;
    // Update is called once per frame
    void Update()
    {
        //X방향  
        if(transform.position.x >= end.x)
        {
            goXend = false;
        }
        if (transform.position.x <= start.x)
        {
            goXend = true;
        }
        if(goXend)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.Translate(-speed * Time.deltaTime, 0, 0);
        }


        //Y방향  
        float ySpeedRate;
        if (수직모드 is true) ySpeedRate = 1;
        else ySpeedRate = yRange / xRange;
        if (transform.position.y >= end.y)
        {
            goYend = false;
        }
        if (transform.position.y <= start.y)
        {
            goYend = true;
        }
        if (goYend)
        {
            transform.Translate(0,speed * Time.deltaTime* ySpeedRate, 0);
        }
        else
        {
            transform.Translate(0,-speed * Time.deltaTime* ySpeedRate, 0);
        }
    }
}
