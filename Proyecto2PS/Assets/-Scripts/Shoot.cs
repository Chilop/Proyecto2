using UnityEngine;
public class Shoot : MonoBehaviour
{
    [SerializeField] private Transform _firepoint = default;
    [SerializeField] private GameObject _bulletprefab = default;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            shoot();
        }
    }
    void shoot()
    {
        GameObject bullet = Instantiate(_bulletprefab, _firepoint.position, _firepoint.rotation);
    }
}
