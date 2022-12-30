using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartManager : NetworkBehaviour
{
    public Button start;
    public GameObject player;
    NetworkManager manager;
    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<NetworkManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(NetworkServer.connections.Count >= 1)
        {
            start.interactable = true;
        }
        else
        {
            start.interactable = false;
        }
    }

    [ServerCallback]
    public void StartGame()
    {
        StartGameSync();
        GameObject[] obj = GameObject.FindGameObjectsWithTag("Panel");
        foreach (GameObject go in obj)
        {
            NetworkServer.Destroy(go);
        }
        manager.ServerChangeScene("SampleScene");
    }
    public void StartGameSync()
    {
        SpawnPrefab.spawn = 0;
        manager.playerPrefab = player;
    }
}
