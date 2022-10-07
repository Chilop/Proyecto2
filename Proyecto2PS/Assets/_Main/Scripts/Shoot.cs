using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firepoint = default;
    [SerializeField] private GameObject _bulletPrefab = default;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        Instantiate(_bulletPrefab, _firepoint.position, _firepoint.rotation);
    }
}
