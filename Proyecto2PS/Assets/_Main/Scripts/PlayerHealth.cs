using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int health = default;
    void Start()
    {
        health = 100;
    }

   
    void Update()
    {
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(!collision.collider.CompareTag("Enemy")) return;
        var enemydamage = collision.gameObject.GetComponent<EnemyDamage>().enemyDamage;

        health -= enemydamage;
    }
}
