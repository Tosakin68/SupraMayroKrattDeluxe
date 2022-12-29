using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody _playerRigidbody;
    public float playerSpeed;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        _playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();

    }

    void Move()
    {
        // _playerRigidbody.velocity = new Vector3(-Input.GetAxis("Vertical") * playerSpeed, _playerRigidbody.velocity.y, _playerRigidbody.velocity.z);
        // transform.Translate(transform.forward * playerSpeed * Time.deltaTime * Input.GetAxis("Vertical"));
        transform.position += -transform.forward * Time.deltaTime * playerSpeed * Input.GetAxis("Vertical");

    }

    void Rotate()
    {
        transform.eulerAngles += new Vector3(0, 1, 0) * rotationSpeed * Time.deltaTime * Input.GetAxis("Horizontal");
    }
}