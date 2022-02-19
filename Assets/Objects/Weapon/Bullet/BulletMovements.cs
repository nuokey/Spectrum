using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovements : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;

    // Update is called once per frame
    void Start()
    {
        rb.AddForce(transform.forward * speed);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        if (collision.gameObject.name == "Enemy(Clone)")
        {
            System.Random rnd = new System.Random();

            collision.transform.localPosition = new Vector3(rnd.Next(-45, 45), 1.5f, rnd.Next(-45, 45));
        }
    }
}