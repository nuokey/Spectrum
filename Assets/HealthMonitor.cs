using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthMonitor : MonoBehaviour
{
    public GameObject player;
    public float healthCount;

    private float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        health = player.GetComponent<Condition>().health;

        if (health >= 90)
        {
            gameObject.GetComponent<Image>().color = new Vector4(0 / 255.0f, 255 / 255.0f, 0 / 255.0f, 0 / 255.0f);
        }
        if (health >= 70 & health < 90)
        {
            gameObject.GetComponent<Image>().color = new Vector4(0 / 255.0f, 255 / 255.0f, 0 / 255.0f, 67 / 255.0f);
        }
        if (health >= 50 & health < 70)
        {
            gameObject.GetComponent<Image>().color = new Vector4(186 / 255.0f, 255 / 255.0f, 0 / 255.0f, 180 / 255.0f);
        }
        if (health >= 30 & health < 50)
        {
            gameObject.GetComponent<Image>().color = new Vector4(255 / 255.0f, 255 / 255.0f, 0 / 255.0f, 255 / 255.0f);
        }
        if (health >= 10 & health < 30)
        {
            gameObject.GetComponent<Image>().color = new Vector4(255 / 255.0f, 186 / 255.0f, 0 / 255.0f, 255 / 255.0f);
        }
        if (health < 10)
        {
            gameObject.GetComponent<Image>().color = new Vector4(255 / 255.0f, 0 / 255.0f, 0 / 255.0f, 255 / 255.0f);
        }
    }
}
