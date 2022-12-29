using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coordination : MonoBehaviour
{
    public int identifier;
    public bool isLast;
    GameObject[] CoordinationObjects;

    void Awake()
    {
        CoordinationObjects = GameObject.FindGameObjectsWithTag("Coordination");
    }

    void Start()
    {
        if (identifier == 0)
        {
            tag = "Coordination";
        }
        else
        {
            tag = "Untagged";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bot"))
        {
            foreach(GameObject obj in CoordinationObjects)
            {
                Debug.Log(CoordinationObjects);
                Coordination coordination = obj.GetComponent<Coordination>();
                if(isLast && coordination.identifier == 0)
                {
                    obj.tag = "Coordination";
                }
                else if (!isLast && coordination.identifier == identifier + 1)
                {
                    obj.tag = "Coordination";
                }
            }
            tag = "Untagged";
        }
    }
}
