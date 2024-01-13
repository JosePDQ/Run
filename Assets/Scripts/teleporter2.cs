using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter2 : MonoBehaviour
{
    Movement player;

    private void Start()
    {
        player = gameObject.GetComponent<Movement>();
    }
    public void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "spikes")
        {
            print("spikes");
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        player.disabled = true;
        yield return new WaitForSeconds(.01f);
        gameObject.transform.position = new Vector3(-43.45945f, 8.04f, -2.306515f);
        yield return new WaitForSeconds(.01f);
        player.disabled = false;
    }
}
