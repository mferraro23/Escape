using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayFootsteps : MonoBehaviour
{
    [SerializeField] private AudioSource source;
    bool isPlaying;
    void Start()
    {
        isPlaying = false;
        source = GetComponent<AudioSource>();
    }

    private void FixedUpdate()
    {
        if (UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.MovementSettings.isMovingStrafe == true || UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.MovementSettings.isMovingForward == true || UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController.MovementSettings.isMovingBackward == true)
        {
            if (!isPlaying)
            {
                //Debug.Log("Playing");
                source.Play();
                isPlaying = true;
            }

        }
        else
        {
            //Debug.Log("NotPlaying");
            source.Stop();
            isPlaying = false;
        }
    }
}
