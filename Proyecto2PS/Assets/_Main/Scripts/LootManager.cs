using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootManager : MonoBehaviour
{
    [SerializeField] private int _killedEnemiesCount;
    [SerializeField] private Transform _transformDropWeapon;
    [SerializeField] private GameObject _gunShotgun;
    [SerializeField] private List<GameObject> _gunsList = new List<GameObject>();

    void Start()
    {
        _gunsList.Add(new GameObject("Shotgun"));
        _gunsList.Add(new GameObject("AssaultRifle"));
    }

    // Update is called once per frame
    void Update()
    {
        CountEnemiesKilled(_killedEnemiesCount);
        if(_killedEnemiesCount == 5)
        {
            Instantiate(_gunShotgun, _transformDropWeapon.position, Quaternion.identity);
        }
    }

    public void CountEnemiesKilled(int killedEnemy)
    {
        _killedEnemiesCount += killedEnemy;
    }
}
