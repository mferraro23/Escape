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

        DontDestroyOnLoad(gameObject);
        Timer.TimeLeft = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        Timer.TimeLeft -= Time.deltaTime;
        float seconds = Mathf.FloorToInt(Timer.TimeLeft);
        TimerText.text = string.Format("{0,00} seconds", seconds);
        if (Timer.TimeLeft <= 0 && Timer.TimerOn == true)
        {
            Debug.Log("You Lost!");
            Timer.TimerOn = false;
        }
    }
}
