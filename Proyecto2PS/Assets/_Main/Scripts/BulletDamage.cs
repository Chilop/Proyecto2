using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    public int Damage { get; private set; }

    public void SetDamage(int bulletdamage)
    {
        Damage = bulletdamage;
    }
}
