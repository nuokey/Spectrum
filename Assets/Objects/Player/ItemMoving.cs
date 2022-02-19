using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMoving : MonoBehaviour
{
    public Rigidbody rb;

    public float moveCoef;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localPosition = new Vector3(0, 1.8f, (Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.z)) / 2 * moveCoef);
    }
}
