using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DontDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        DontDestroyOnLoad(gameObject);
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "Startup")
        {
            GameObject.Find("PlayBackgroundMusic").GetComponent<AudioSource>().Play();
            SceneManager.LoadScene("Menu");
        }
        
    }
}
