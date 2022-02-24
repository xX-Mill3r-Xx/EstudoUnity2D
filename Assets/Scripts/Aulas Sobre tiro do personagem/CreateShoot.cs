using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateShoot : MonoBehaviour
{
    public GameObject bullets;
    public GameObject weapon;
    public float bulletTimeLife;
    public float maxTimeLifeBullet;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullets, new Vector3(weapon.transform.position.x,
                weapon.transform.position.y,
                weapon.transform.position.z),Quaternion.identity);
        }
        
    }
}
