using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   public Transform firepoint;
   [SerializeField]private GameObject bulletprefab;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletprefab, firepoint.position,firepoint.rotation);     
    }

}
