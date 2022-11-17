using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _bulletspeed = 0.1f;

    void Update()
    {
        transform.position += transform.up * _bulletspeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!collision.CompareTag("Enemy")) return;

        Destroy(gameObject);
    }
}
