using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PickUpItem : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;
    [SerializeField] private GameObject TimeRemaining;
    [SerializeField] private GameObject Batteries;


    private void Start()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(gameObject.tag == "batteries")
            {
                Instantiate(Batteries, other.transform, true);
                AudioSource.PlayClipAtPoint(clip, transform.position);
                Destroy(gameObject);
                TurnFlashlightOn.TimeLeft += 5.0f;

            }
            if (gameObject.tag == "clock")
            {
                Instantiate(TimeRemaining, other.transform, true);
                AudioSource.PlayClipAtPoint(clip, transform.position);
                Destroy(gameObject);
                Timer.TimeLeft += 20.0f;
            }

        }
        
    }




}
