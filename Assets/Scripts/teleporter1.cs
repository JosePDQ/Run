using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter1 : MonoBehaviour
{
    StarterAssets.FirstPersonController player;

    private void Start()
    {
        player = gameObject.GetComponent<StarterAssets.FirstPersonController>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Box1")
        {
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        player.disabled = true;
        yield return new WaitForSeconds(.01f);
        gameObject.transform.position = new Vector3(-34.05f, 0, -2);
        yield return new WaitForSeconds(.01f);
        player.disabled = false;
    }
}
