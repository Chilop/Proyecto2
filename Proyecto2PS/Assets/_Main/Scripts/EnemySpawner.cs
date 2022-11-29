using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab = null;
    [SerializeField] private float _spawnInterval = default;

    void Start()
    {
        StartCoroutine(SpawnEnemyCoroutine());
    }

    IEnumerator SpawnEnemyCoroutine()
    {
        yield return new WaitForSeconds(_spawnInterval);
        GameObject newEnemy = Instantiate(_enemyPrefab, new Vector2(Random.Range(-6f, 6f), Random.Range(-7f, 7f)), Quaternion.identity);
        StartCoroutine(SpawnEnemyCoroutine());
    }
}
