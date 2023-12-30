using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject payerPrefab;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float maxZ;
    public float minZ;

    private void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(minX, maxX), Random.Range(minY, maxY), Random.Range(minZ, maxZ));
        PhotonNetwork.Instantiate(payerPrefab.name, randomPosition, Quaternion.identity);
    }
}
