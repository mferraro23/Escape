using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public TMP_Text TimerText;
    
    // Start is called before the first frame update
    void Start()
    {
        Scene scene = SceneManager.GetActiveScene();
        if (scene.name != "Menu" || scene.name != "Win" || scene.name != "Lost")
        {
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        
        Timer.TimerOn = true;
        Timer.TimeLeft = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer.TimerOn == true)
        {
            Timer.TimeLeft -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(Timer.TimeLeft);
            TimerText.text = string.Format("{0,00} seconds reamin to escape...", seconds);
            if (Timer.TimeLeft <= 0)
            {
                
                Timer.TimerOn = false;
                TimerText.text = "0 seconds";
                Destroy(gameObject);
                SceneManager.LoadScene("Lost");
            }
        }
    }
}
