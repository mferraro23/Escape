using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement03 : MonoBehaviour
{
    void OnTriggerEnter(Collider ChangeScene)
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("Scene_05");
        }
    }
}
