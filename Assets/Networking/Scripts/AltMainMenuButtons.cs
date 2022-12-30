using Mirror;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AltMainMenuButtons : MonoBehaviour
{
    public NetworkManager manager;
    public GameObject inputCanvas;
    public GameObject mainmenuCanvas;
    public TMP_InputField ipInput;
    public Button joinbutton;
    public static string ipAdress;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ipAdress = ipInput.text;
        if(inputCanvas == isActiveAndEnabled)
        {
            if (ipInput.text == "")
            {
                joinbutton.interactable = false;
            }
            else
            {
                joinbutton.interactable = true;
            }
        }
    }

    public void JoinClickMainMenu()
    {
        mainmenuCanvas.SetActive(false);
        inputCanvas.SetActive(true);
    }

    public void HostClick()
    {
        manager.StartHost();
    }

    public void JoinClickFinal()
    {
        manager.networkAddress = ipAdress;
        manager.StartClient();
    }

    public void ExitClick()
    {
        inputCanvas.SetActive(false);
        mainmenuCanvas.SetActive(true);
    }

    public void ServerClick()
    {
        manager.StartServer();
    }
}
