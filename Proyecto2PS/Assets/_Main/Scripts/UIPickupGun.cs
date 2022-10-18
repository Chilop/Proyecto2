using UnityEngine;
public class UIPickupGun : MonoBehaviour
{
    [SerializeField] GameObject _menuPick = null;

    private GunsMutations _mutation = null;
    private GunsInfo _gunsInfo = null;

    void Start()
    {
        _menuPick.SetActive(false);
    }

    public void Appear(GunsMutations mutation, GunsInfo gunsinfo)
    {
        _mutation = mutation;
        _gunsInfo = gunsinfo;
        _menuPick.SetActive(true);
    }

    public void ButtonPickGunup()
    {
        GunsManager.Instance.SetGun(_gunsInfo);
        Destroy(_mutation.gameObject);
        _gunsInfo = null;
        _menuPick.SetActive(false);
    }

    public void ButtonKeepGun()
    {
        _mutation = null;
        _gunsInfo = null;
        _menuPick.SetActive(false);
    }

}
