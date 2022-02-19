using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotsController : MonoBehaviour
{
    public new GameObject camera;

    public GameObject slot_1;
    public GameObject slot_2;

    

    void Update()
    {
        SlotChanger();
        ItemRotation();
    }

    void SlotChanger()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            slot_1.SetActive(true);
            slot_2.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            slot_1.SetActive(false);
            slot_2.SetActive(true);
        }
    }

    void ItemRotation()
    {
        slot_1.transform.rotation = camera.transform.rotation;
        slot_2.transform.rotation = camera.transform.rotation;
    }
}
