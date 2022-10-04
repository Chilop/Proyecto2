using UnityEngine;

public class Guns_Mutations : MonoBehaviour
{
    [SerializeField] private GunsInfo gunsinfo = default;
    [SerializeField] private UIPickupGun MenuPickupGun = default;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gunsinfo.MutationName);
        Debug.Log(gunsinfo.Description);
        Debug.Log(gunsinfo.Damage);
        MenuPickupGun.Appear(gunsinfo);
    }
}