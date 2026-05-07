using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 20f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * speed, ForceMode.Impulse);
        Destroy(gameObject, 3f); // Destroy the bullet after 3 seconds to prevent memory leaks
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
