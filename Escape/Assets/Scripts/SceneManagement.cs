using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string switchScene = "Scene_03";
    void OnTriggerEnter(Collider ChangeScene)
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(switchScene);
        }
    }

    public void switchToMenu()
    {
        SceneManager.LoadScene(switchScene);
    }

    public void Play()
    {
        SceneManager.LoadScene(switchScene);
    }
}
