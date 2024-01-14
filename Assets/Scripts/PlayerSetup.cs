using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerSetup : MonoBehaviour
{
    public Movement movement;
    public End end;

    public GameObject Cam;
   
   


    public void isLocalPLayer()
    {
        end.enabled = true;
        movement.enabled = true;
        Cam.SetActive(true);
        
        
    }
}
