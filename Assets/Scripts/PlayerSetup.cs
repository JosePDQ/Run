using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerSetup : MonoBehaviour
{
    public Movement movement;

    public GameObject Cam;
   
   


    public void isLocalPLayer()
    {
        movement.enabled = true;
        Cam.SetActive(true);
        
        
    }
}
