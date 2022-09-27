using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrincipalWeapon : MonoBehaviour
{
    [SerializeField] private Transform firepoint;
    public GameObject bulletprefab;

    [SerializeField]private float bulletforce;
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }


    void shoot()
    {
        GameObject bullet = Instantiate(bulletprefab,firepoint.position, firepoint.rotation);
    }



}
