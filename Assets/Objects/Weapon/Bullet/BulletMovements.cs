using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletMovements : MonoBehaviour
{
    public float speed;
    public Rigidbody rb;
    public float damage;

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
            collision.gameObject.GetComponent<EntityCondition>().health -= damage;
        }
    }
}