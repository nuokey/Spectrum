using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUsing : MonoBehaviour
{
    public GameObject takeText;

    public Transform inventory;

    public bool textActive;

    // Update is called once per frame
    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        Debug.DrawRay(transform.position, transform.forward * 100f, Color.yellow);

        textActive = false;
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider.gameObject.GetComponent<Item>())
            {
                textActive = true;
                if (Input.GetKey(KeyCode.E))
                {
                    //hit.collider.gameObject.transform.position = hit.collider.gameObject.GetComponent<Item>().defaultOffset;
                    //hit.collider.gameObject.transform.localEulerAngles = hit.collider.gameObject.GetComponent<Item>().defaultRotation;
                    hit.collider.gameObject.transform.SetParent(inventory);
                    hit.collider.gameObject.GetComponent<Item>().Get();
                }
            }
        }
        if (takeText.activeSelf != textActive)
        {
            takeText.SetActive(textActive);
        }
        
    }
}
