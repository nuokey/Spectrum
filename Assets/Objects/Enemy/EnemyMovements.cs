using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovements : MonoBehaviour
{
    public float damage;
    public float speed;
    public float biteCooldown;

    private GameObject target;

    public Rigidbody rb;

    private bool readyToBite = true;

    // Update is called once per frame
    void Update()
    {
        target = GameObject.Find("Player");
        transform.LookAt(target.transform);
    }

    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.red);

        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {   
            if (hit.collider.gameObject.name == "Player")
            {
                rb.AddForce(transform.forward * speed);
            }
        }
    }

    void GetReady()
    {
        readyToBite = true;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" & readyToBite)
        {
            collision.gameObject.GetComponent<Condition>().health -= damage;
            readyToBite = false;
            Invoke("GetReady", biteCooldown);
        }
    }
}
