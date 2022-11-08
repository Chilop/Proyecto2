using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _enemyLife = default;
    [SerializeField] private EnemyScriptableObject _enemyScriptableObject;

    void Start()
    {
        SetHealth(_enemyScriptableObject.Health);
    }

    private void Update()
    {
        if(_enemyLife <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Bullet")) return;

        var bulletDamage = collision.gameObject.GetComponent<BulletDamage>().Damage;

        _enemyLife = _enemyLife - bulletDamage;
    }

    public void SetHealth(int _enemyhealth)
    {
        _enemyLife = _enemyhealth;
    }

}
