using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter : MonoBehaviour
{
    StarterAssets.FirstPersonController player;

    private void Start()
    {
        player = gameObject.GetComponent<StarterAssets.FirstPersonController>();
    }
    public void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box")
        {
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        player.disabled = true;
        yield return new WaitForSeconds(.01f);
        gameObject.transform.position = new Vector3(-4.13f, -0.1985935f, -3.45f);
        yield return new WaitForSeconds(.01f);
        player.disabled = false;
    }

    
}
