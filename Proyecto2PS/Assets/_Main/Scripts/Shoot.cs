using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firepoint = default;
    [SerializeField] private GameObject _bulletPrefab = default;
    private float _shootInterval = 1f;

    void Start()
    {
       StartCoroutine(timerShoot(_shootInterval));    
    }

    public void ShootBullet()
    {
        Instantiate(_bulletPrefab, _firepoint.position, _firepoint.rotation);
    }

    IEnumerator timerShoot(float interval)
    {
        yield return new WaitForSeconds(interval);
        ShootBullet();
        StartCoroutine(timerShoot(interval));

    }
}
