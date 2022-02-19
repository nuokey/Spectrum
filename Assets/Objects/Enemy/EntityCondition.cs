using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityCondition : MonoBehaviour
{
    public float maxHealth;
    public float health;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            System.Random rnd = new System.Random();

            transform.localPosition = new Vector3(rnd.Next(-45, 45), 1.5f, rnd.Next(-45, 45));
            health = maxHealth;

        }
    }
}
