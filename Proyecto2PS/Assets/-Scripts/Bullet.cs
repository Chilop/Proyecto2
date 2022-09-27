using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]private float bulletSpeed = 20f;

    private void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        Destroy(gameObject);
    }
}
