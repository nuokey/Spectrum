using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    private GameObject target;
    public float speed;
    public Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player");
        transform.LookAt(target.transform);
    }

    void FixedUpdate()
    {
        rb.AddForce(transform.forward * speed);
    }
}
