
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int enemyDamage { get; private set; }
    [SerializeField] private EnemyScriptableObject _enemyScriptableObject = null;

    void Start()
    {
        SetEnemyDamage(_enemyScriptableObject.Damage);
    }

    public void SetEnemyDamage(int _enemydamage)
    {
        enemyDamage = _enemydamage;
    }
}
