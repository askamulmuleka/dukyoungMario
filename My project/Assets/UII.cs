using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UII : MonoBehaviour
{
    static public UII instance;
    UII()
    {
        instance = this;
    }
    public void MainSceneChange()
    {
        SceneManager.LoadScene(0);
    }
    public void GameSceneChange()
    {
        SceneManager.LoadScene(1);
    }
    public void GoalSceneChange()
    {
        SceneManager.LoadScene(1);
    }
}
