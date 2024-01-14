using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class End : MonoBehaviour
{
    Movement player;
    public GameObject canvas;

    private void Start()
    {
        player = gameObject.GetComponent<Movement>();
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "final")
        {

            canvas.SetActive(true);
            print("you won");
        }

    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "final")
        {

            canvas.SetActive(false);
            print("you won");
        }

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
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
