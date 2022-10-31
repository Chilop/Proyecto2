using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private int _enemyLife = default;
    private EnemyScriptableObject _enemyScriptableObject;
    void Start()
    {

    }

    void Update()
    {
        SetHealth(_enemyLife);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Bullet")) return;

        collision.gameObject.GetComponent<BulletDamage>();

        _enemyLife = _enemyLife - 1;
    }

    public void SetHealth(int _health)
    {
        _enemyLife = _enemyScriptableObject.Health;
    }

}
