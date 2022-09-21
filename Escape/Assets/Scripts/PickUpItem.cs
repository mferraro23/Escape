using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpItem : MonoBehaviour
{
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(gameObject.tag == "batteries")
            {
                Destroy(gameObject);
                TurnFlashlightOn.TimeLeft += 5.0f;
            }
            if (gameObject.tag == "clock")
            {
                Destroy(gameObject);
                Timer.TimeLeft += 5.0f;
            }

        }
    }
}
