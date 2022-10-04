using UnityEngine;
public class UIPickupGun : MonoBehaviour
{
    GunsInfo gunsinfo;
    [SerializeField] GameObject Menupick;
    void Start()
    {
        Menupick.SetActive(false);
    }
    
    public void Appear(GunsInfo gunsinfo)
    {
        this.gunsinfo = gunsinfo;
        Menupick.SetActive(true);
    }

    public void ButtonPickGunup()
    {
        GunsManager.instance.SetGun(gunsinfo);
        Menupick.SetActive(false);
    }

    public void ButtonKeepGun()
    {
        if (gunsinfo != null)
        {
            gunsinfo = gunsinfo;

            Menupick.SetActive(false);
        }
    }
}
