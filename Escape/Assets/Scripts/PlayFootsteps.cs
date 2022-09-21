using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFootsteps : MonoBehaviour
{
    public AudioSource audio;
    bool isPlaying;
    void Start()
    {
        isPlaying = false;
        audio = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.MovementSettings.isMovingStrafe == true || UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.MovementSettings.isMovingForward == true || UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.MovementSettings.isMovingBackward == true)
        {
            if (!isPlaying)
            {
                //Debug.Log("Playing");
                audio.Play();
                isPlaying = true;
            }

        }
        else
        {
            //Debug.Log("NotPlaying");
            audio.Stop();
            isPlaying = false;
        }
    }
}
