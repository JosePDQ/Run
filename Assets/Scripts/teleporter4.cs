using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter4 : MonoBehaviour
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
        if (other.gameObject.tag == "blade")
        {
            print("spikes");
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        player.disabled = true;
        yield return new WaitForSeconds(.01f);
        gameObject.transform.position = new Vector3(-37.48f, 20f, -1.999999f);
        yield return new WaitForSeconds(.01f);
        player.disabled = false;
    }
}
