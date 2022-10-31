
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] private int _bulletDamage = default;
    private GunsInfo _gunsScriptableObject;

    private void Start()
    {
        SetDamage(_bulletDamage);
    }

    public void SetDamage(int _damagebullet)
    {
        _bulletDamage = _gunsScriptableObject.Damage;
    }
}
