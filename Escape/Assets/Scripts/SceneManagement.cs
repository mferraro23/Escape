using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public string switchScene = "Scene_03";

    private void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "Menu" || scene.name != "Win" || scene.name != "Lost")
        {
            Cursor.visible = false;
        }
        else
        {
            Cursor.visible = true;
        }
            
    }

    void OnTriggerEnter(Collider ChangeScene)
    {
        if (ChangeScene.gameObject.CompareTag("Player"))
        {
            if(switchScene == "Win")
            {

                Destroy(GameObject.Find("TimerManager"));
                GameObject.Find("PlayBackgroundMusic").GetComponent<AudioSource>().Pause();
            }
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
