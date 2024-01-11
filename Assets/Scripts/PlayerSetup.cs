using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
