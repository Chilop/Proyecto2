using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar = null;
    [SerializeField] private int maxHealth = 100;
    [SerializeField] int _health = default;


    void Start()
    {
        _health = maxHealth;
        _healthBar.SetMaxHealth(maxHealth);
    }


    void Update()
    {
        if (_health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;
        var enemydamage = collision.gameObject.GetComponent<EnemyDamage>().enemyDamage;

        _health -= enemydamage;

        _healthBar.SetPlayerHealth(_health);      
    }
}
