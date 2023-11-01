using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float timeWating;
    float timer = 0;
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeWating )
        {
            SceneManager.LoadScene(0);
        }
    }
}
