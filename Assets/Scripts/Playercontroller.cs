using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float speed;

    private Rigidbody rig;

    private void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            rig.velocity = new Vector3(0, 0, speed);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rig.velocity = new Vector3(0, 0, -speed);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            rig.velocity = new Vector3(-speed, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            rig.velocity = new Vector3(speed, 0, 0);
        }

        transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);
    }
}