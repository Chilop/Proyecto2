using System.Collections;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firepoint = default;
    [SerializeField] private GameObject _bulletPrefab = default;
    [SerializeField] GunsInfo _gunsinfo = default;
    [SerializeField] private AudioClip _audioGunSound = null;
    private float _shootInterval = 1f;

    void Start()
    {
        StartCoroutine(timerShoot(_shootInterval));
    }

    public void ShootBullet()
    {
       var bullet = Instantiate(_bulletPrefab, _firepoint.position, _firepoint.rotation);
        bullet.GetComponent<BulletDamage>().SetDamage(_gunsinfo.Damage);
        AudioManager.Instance.ShootPlayer();
        Debug.Log("Bala con da?o");
    }
     
    IEnumerator timerShoot(float interval)
    {
        yield return new WaitForSeconds(interval);
        ShootBullet();
        StartCoroutine(timerShoot(interval));
    }

    public void GetAudioSource(AudioSource audioSource)
    {

    }
}
