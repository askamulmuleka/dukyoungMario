using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vector = target.transform.position - transform.position;
        float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        
    }
    public GameObject target;
    public float speed;

    public bool IsGuidedMissile = false;

    float timer = 0;
    public float lifeTime;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(IsGuidedMissile is true)
        {
            Vector3 vector = target.transform.position - transform.position;
            float rotZ = Mathf.Atan2(vector.y, vector.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, 0, rotZ);
        }
        transform.Translate(speed * Time.deltaTime, 0, 0);


        //Á×´ÂÄÚµå
        if(timer>lifeTime)
        {
            Destroy(this.gameObject);
        }
    }
}
;