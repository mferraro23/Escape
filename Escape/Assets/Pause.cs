using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] GameObject pauseMenue;
   
   public void Resume()
   {
        pauseMenue.SetActive(false);
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
        if (Input.GetKey(KeyCode.Escape))
        {
            pauseMenue.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
