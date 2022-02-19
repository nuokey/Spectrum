using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private bool inArmsBool = true;

    public Vector3 defaultOffset;
    public Vector3 defaultRotation;



    // Update is called once per frame
    void Update()
    {
        Drop();
    }

    public void Get()
    {
        transform.localPosition = defaultOffset;
        transform.localEulerAngles = defaultRotation;
    }

    void Drop()
    {
        if (Input.GetKeyDown(KeyCode.Q) & inArmsBool)
        {
            inArmsBool = false;
            gameObject.AddComponent<Rigidbody>();
            transform.SetParent(GameObject.Find("Items").transform);
            GetComponent<BoxCollider>().enabled = true;
        }
    }
}
