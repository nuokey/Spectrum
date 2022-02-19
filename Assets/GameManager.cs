using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject colt1911;
    public int enemyCount;

    public Transform items;
    
    // Start is called before the first frame update
    void Start()
    {
        System.Random rnd = new System.Random();
        for (int i = 0; i < enemyCount; i++)
        {
            Instantiate(enemy, new Vector3(rnd.Next(-45, 45), 1.5f, rnd.Next(-45, 45)), transform.rotation);
        }
        // Instantiate(colt1911, new Vector3(0, 2, 0), new Quaternion(), items);
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
