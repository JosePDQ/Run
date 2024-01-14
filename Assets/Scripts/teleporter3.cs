using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleporter3 : MonoBehaviour
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
        if (other.gameObject.tag == "box3")
        {
            print("spikes");
            StartCoroutine("Teleport");
        }
    }

    IEnumerator Teleport()
    {
        player.disabled = true;
        yield return new WaitForSeconds(.01f);
        gameObject.transform.position = new Vector3(-67.48f, 7f, -2f);
        yield return new WaitForSeconds(.01f);
        player.disabled = false;
    }
}
