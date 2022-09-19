using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFlashlightOn : MonoBehaviour
{
    public static bool isOn;
    public static bool canTurnOn;
    public static Light myLight;
    int flag;
    public static float TimeLeft;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        flag = 1;
        isOn = false;
        canTurnOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1 && Input.GetKeyDown(KeyCode.R) && canTurnOn == true)
        {
            myLight.range = 8;
            myLight.intensity = 17;
            flag = 0;
            isOn = true;
            
        }
        else if (flag == 0 && Input.GetKeyDown(KeyCode.R) && canTurnOn == true)
        {
            myLight.range = 5;
            myLight.intensity = 10;
            flag = 1;
            isOn = false;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R) && canTurnOn == false)
            {
                myLight.range = 5;
                myLight.intensity = 10;
                flag = -1;
                isOn = false;
            }
        }
    }
}
