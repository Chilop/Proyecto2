using UnityEngine;

public class GunsMutations : MonoBehaviour
{
    [SerializeField] private GunsInfo _gunsInfo = default;
    [SerializeField] private UIPickupGun _menuPickupGun = default;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(!other.CompareTag("Player")) return;
        _menuPickupGun.Appear(this, _gunsInfo);
    }
}
