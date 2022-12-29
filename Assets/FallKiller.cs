using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallKiller : MonoBehaviour
{
    public float deathpos;
    Vector3 startpos;
    void Start()
    {
        startpos = transform.position;
    }
    void Update()
    {
        if(transform.position.y <= deathpos)
        {
            transform.position = startpos;
        }
    }
}
