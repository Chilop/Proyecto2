using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject _enemyPrefab = null;
    [SerializeField] private float _spawnInterval = default;
    
    void Start()
    {
        StartCoroutine(_spawnenemy(_spawnInterval, _enemyPrefab));
    }

    IEnumerator _spawnenemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy,new Vector2(Random.Range(-6f,6f),Random.Range(-7f,7f)), Quaternion.identity);
        StartCoroutine(_spawnenemy(interval, enemy));
    }
}
