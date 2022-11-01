
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    [SerializeField] private int _bulletDamage = default;
    private GunsInfo _gunsScriptableObject;

    public void SetDamage(GunsInfo gunsInfo)
    {
        _bulletDamage = _gunsScriptableObject.Damage;
    }
}
