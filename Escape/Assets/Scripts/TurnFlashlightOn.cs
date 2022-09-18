using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnFlashlightOn : MonoBehaviour
{
    Light myLight;
    int flag;

    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        flag = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (flag == 1 && Input.GetKeyDown(KeyCode.R))
        {
            myLight.range = 8;
            myLight.intensity = 17;
            flag = 0;
            
        }
        else if (flag == 0 && Input.GetKeyDown(KeyCode.R))
        {
            myLight.range = 5;
            myLight.intensity = 10;
            flag = 1;
        }
    }
}
