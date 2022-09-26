using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PickUpItem : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

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
                AudioSource.PlayClipAtPoint(clip, transform.position);
                Destroy(gameObject);
                TurnFlashlightOn.TimeLeft += 5.0f;
            }
            if (gameObject.tag == "clock")
            {

                AudioSource.PlayClipAtPoint(clip, transform.position);
                Destroy(gameObject);
                Timer.TimeLeft += 5.0f;
            }

        }
    }
}
