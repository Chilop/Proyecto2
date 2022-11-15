using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyDamage { get; private set; }
    [SerializeField] private EnemyScriptableObject _enemyScriptableObject = null;
    void Start()
    {
        SetEnemyDamage(_enemyScriptableObject.Damage);
    }

    void Update()
    {

    }

    public void SetEnemyDamage(int _enemydamage)
    {
        enemyDamage = _enemydamage;
    }
}