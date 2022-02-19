using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour
{
    public float fireDelay;
    public float reloadDuration;
    public float zoomSlowdown;
    public float damage;
    public string GunType;

    public GameObject bullet;
    public GameObject fireParticles;
    public GameObject player;
    public GameObject ammo;

    public string FireAnimation;
    public string ZoomFireAnimation;
    public string ReloadAnimation;
    public string ZoomAnimation;

    public Vector3 defaultOffset;
    public Vector3 zoomOffset;

    public Transform bullets;

    public float yOffset;
    
    private bool readyToFire = true;
    public bool zoomed = false;

    private GameObject lastBullet;

    void Start()
    {
        player = GameObject.Find("Player");
        ammo = GameObject.Find("Ammo");
        bullets = GameObject.Find("Bullets").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.parent.gameObject.name == "Slot_1")
        {
            InArms();
        }
        
        Reload();
    }

    void GetReady()
    {   
        readyToFire = true;
    }

    void AfterReload()
    {
        readyToFire = true;
        ammo.GetComponent<Ammo>().ammo = ammo.GetComponent<Ammo>().maxAmmo;
    }

    void InArms()
    {   

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Fire();
        }
        Zoom();
    }

    void Zoom()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GetComponent<Animation>().Stop();
            GetComponent<Animation>().Play(ZoomAnimation);
            zoomed = true;
            player.GetComponent<PlayerMovements>().speed = player.GetComponent<PlayerMovements>().speed * zoomSlowdown;
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            GetComponent<Animation>().Stop();
            transform.localPosition = defaultOffset;
            zoomed = false;
            player.GetComponent<PlayerMovements>().speed = player.GetComponent<PlayerMovements>().speed / zoomSlowdown;
        }
    }

    void Reload()
    {   
        if (Input.GetKey(KeyCode.R) & readyToFire)
        {
            readyToFire = false;
            Invoke("AfterReload", reloadDuration);
        }
    }

    void Fire()
    {
        if (readyToFire & ammo.GetComponent<Ammo>().ammo > 0)
        {
            lastBullet = Instantiate(bullet, new Vector3(transform.position.x, transform.position.y + yOffset, transform.position.z), transform.rotation, bullets);

            lastBullet.GetComponent<BulletMovements>().damage = damage;
            
            fireParticles.SetActive(true);
            readyToFire = false;

            ammo.GetComponent<Ammo>().ammo -= 1;

            if (zoomed)
            {
                GetComponent<Animation>().Play(ZoomFireAnimation);
            }
            else
            {
                GetComponent<Animation>().Play(FireAnimation);
            }
            Invoke("GetReady", fireDelay);
        }
    }
}
