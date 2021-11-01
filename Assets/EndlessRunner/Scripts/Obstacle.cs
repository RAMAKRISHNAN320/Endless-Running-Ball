using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private float waitSeconds = 1f;
    Rigidbody myrigidbody;
    MeshRenderer myrenderer;
    // Start is called before the first frame update
    void Start()
    {
        myrenderer= GetComponent<MeshRenderer>();
        myrigidbody = GetComponent<Rigidbody>();
        myrenderer.enabled = false;
        myrigidbody.useGravity = false;
    }
    void Update()
    {
        if (Time.time > waitSeconds)
        {
            myrenderer.enabled = true;
            myrigidbody.useGravity = true;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            // Kill the player
        }
    }

}
