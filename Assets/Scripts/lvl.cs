using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using Photon.Realtime;
public class lvl : MonoBehaviour
{
    public static LoadBalancingClient NetworkingClient;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "End")
        {
            StartCoroutine("lvl2");
        }
    }

    IEnumerator lvl2()
    {
        PhotonNetwork.Disconnect();
        yield return new WaitForSeconds(2);
        PhotonNetwork.LoadLevel("Game2");
       
    }
}
