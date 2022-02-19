using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Ammo : MonoBehaviour
{   
    public int maxAmmo;
    public int ammo;

    public GameObject ammoCount;

    void Start()
    {
        ammoCount = GameObject.Find("AmmoCount");
    }

    // Update is called once per frame
    void Update()
    {
        ammoCount.GetComponent<Text>().text = System.Convert.ToString(ammo) + " \\ " + System.Convert.ToString(maxAmmo);
    }
}
