using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource sfx;
    Rigidbody rb;
    float modifier;
    void Start()
    {
        sfx = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        modifier = rb.velocity.x / 100;
        if (modifier < 0)
        {
            modifier = modifier + (-modifier) + (-modifier);
        }
        sfx.pitch = 1 + modifier;
    }
}
