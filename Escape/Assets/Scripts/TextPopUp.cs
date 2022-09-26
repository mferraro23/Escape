using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextPopUp : MonoBehaviour
{
    [SerializeField] public Transform PopUp;
    [SerializeField] public TMP_Text Text;
    Vector3 location;
    Quaternion rotation;

    private void Start()
    {
        
    }
    public void popUp()
    {
        location.x = -35;
        location.y = -85;
        location.z = 0;
        Instantiate(Text, location, rotation);
    }

}
