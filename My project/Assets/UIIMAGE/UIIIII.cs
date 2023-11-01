using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIIIII : MonoBehaviour
{
    public void GameSceneChange()
    {
        SceneManager.LoadScene(0);
    }
    public void MainSceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
