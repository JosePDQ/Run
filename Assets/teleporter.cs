using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    [SerializeField]
    public GameObject player;
    [SerializeField]
    public GameObject tp;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box")
        {
            print("a");

            player.transform.position = tp.transform.position;
        }
    }
}
