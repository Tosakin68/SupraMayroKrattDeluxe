using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LobbyButtons : MonoBehaviour
{
    NetworkManager manager;
    public GameObject IPText;
    // Start is called before the first frame update

    void Awake()
    {
        EnterIPAdress();
    }
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("NetworkManager").GetComponent<NetworkManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisconnectButton()
    {
        // stop host if host mode
        if (NetworkServer.active && NetworkClient.isConnected)
        {
            manager.StopHost();
        }
        // stop client if client-only
        else if (NetworkClient.isConnected)
        {
            manager.StopClient();
        }
        else if (NetworkServer.active)
        {
            manager.StopServer();
        }
    }

    void EnterIPAdress()
    {
        if(NetworkServer.active)
        {
            IPText.SetActive(true);
            TextMeshProUGUI ipshow = IPText.GetComponent<TextMeshProUGUI>();
            string ip = GlobalIP.GetGlobalIPAddress();
            ipshow.SetText("Host IP: " + ip);
        }
        else
        {
            IPText.SetActive(false);
        }
    }
}
