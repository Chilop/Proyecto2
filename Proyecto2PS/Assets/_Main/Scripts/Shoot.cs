using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firepoint = default;
    [SerializeField] private GameObject _bulletPrefab = default;
    GunsInfo _gunsinfo;
    private float _shootInterval = 1f;

    void Start()
    {
        StartCoroutine(timerShoot(_shootInterval));
    }

    public void ShootBullet()
    {
       var bullet = Instantiate(_bulletPrefab, _firepoint.position, _firepoint.rotation);
        bullet.GetComponent<BulletDamage>().SetDamage(_gunsinfo.Damage); 
    }

    IEnumerator timerShoot(float interval)
    {
        yield return new WaitForSeconds(interval);
        ShootBullet();
        StartCoroutine(timerShoot(interval));
    }
}
