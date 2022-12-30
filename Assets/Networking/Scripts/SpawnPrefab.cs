using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
using UnityEngine.Networking.Types;

public class SpawnPrefab : NetworkBehaviour
{
    public static int spawn;
    public GameObject panel;
    public static string[] usernames;
    // Start is called before the first frame update
    void Awake()
    {
        int counter = 0;
        GameObject[] panels = GameObject.FindGameObjectsWithTag("Panel");
        foreach (GameObject obj in panels)
        {
            counter++;
        }
        if (counter == 1)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn1").transform.position;
        }
        if(counter == 2)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn2").transform.position;
        }
        if (counter == 3)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn3").transform.position;
        }
        if (counter == 4)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn4").transform.position;
        }
        if (counter == 5)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn5").transform.position;
        }
        if (counter == 6)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn6").transform.position;
        }
        if (counter == 7)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn7").transform.position;
        }
        if (counter == 8)
        {
            panel.transform.position = GameObject.FindGameObjectWithTag("spawn8").transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
    
    }


}
