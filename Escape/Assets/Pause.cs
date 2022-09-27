using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenue;
    int flag = 0;
   
   public void Resume()
   {
        pauseMenue.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1.0f;
   }
    public void Menu()
    {
        pauseMenue.SetActive(false);
        SceneManager.LoadScene("Startup");
        Time.timeScale = 1.0f;
        Destroy(GameObject.Find("TimerManager"));
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && flag == 0)
        {
            pauseMenue.SetActive(true);
            Time.timeScale = 0f;
            flag = 1;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && flag == 1)
        {
            pauseMenue.SetActive(false);
            Time.timeScale = 1f;
            flag = 0;
        }
    }
}
