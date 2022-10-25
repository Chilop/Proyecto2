using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firepoint = default;
    [SerializeField] private GameObject _bulletPrefab = default;
    private GunsInfo _gunsInfo = default;
    private int _bulletDamage = default;
    private float _shootInterval = 1f;

    void Start()
    {
       StartCoroutine(timerShoot(_shootInterval));    
    }

    public void ShootBullet()
    {
        var bullet = Instantiate(_bulletPrefab, _firepoint.position, _firepoint.rotation);
        bullet.GetComponent<ScriptableObject>();
    }

    IEnumerator timerShoot(float interval)
    {
        yield return new WaitForSeconds(interval);
        ShootBullet();
        StartCoroutine(timerShoot(interval));

    }

    public void SetDamage()
    {
        _bulletDamage = _gunsInfo.Damage;
    }
}
