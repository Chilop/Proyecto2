using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour
{
    [SerializeField] private int _killedEnemiesCount;
    [SerializeField] private Transform _transformDropWeapon;
    [SerializeField] private GameObject _prefabShotgun;
    [SerializeField] private GameObject _prefabGatling;
    [SerializeField] private GameObject _prefabDefaultGun;
    [SerializeField] private List<GameObject> _gunsList = new List<GameObject>();

    void Start()
    {
        _prefabDefaultGun = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        CountEnemiesKilled(_killedEnemiesCount);
        if (_killedEnemiesCount == 5)
        {
            int index = Random.Range(0 + 1, _gunsList.Count);
            Instantiate(_gunsList[index], _transformDropWeapon.position, Quaternion.identity);
        }
    }

    public void CountEnemiesKilled(int killedEnemy)
    {
        _killedEnemiesCount += killedEnemy;
    }
}
