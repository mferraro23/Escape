using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlashLightTime : MonoBehaviour
{
    public TMP_Text FlashLightBattery;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        TurnFlashlightOn.TimeLeft = 8.0f;
        FlashLightBattery.text = string.Format("Power Remaining: 80");
    }

    // Update is called once per frame
    void Update()
    {
        if (TurnFlashlightOn.isOn == true)
        {
            TurnFlashlightOn.TimeLeft -= Time.deltaTime;
            float seconds = Mathf.FloorToInt(TurnFlashlightOn.TimeLeft);
            FlashLightBattery.text = string.Format("Power Remaining: {0,00}", seconds);

            if(seconds <= 0)
            {
                TurnFlashlightOn.canTurnOn = false;
                TurnFlashlightOn.isOn = false;
                TurnFlashlightOn.myLight.range = 5;
                TurnFlashlightOn.myLight.intensity = 10;
                FlashLightBattery.text = "Power Remaining: 0";
            }
        }
    }
}
