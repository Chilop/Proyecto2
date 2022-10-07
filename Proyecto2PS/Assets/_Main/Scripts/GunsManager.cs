using UnityEngine;

public class GunsManager : MonoBehaviour
{
    public static GunsManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    public void SetGun(GunsInfo gunsInfo)
    {
        Player.Instance.SetGun(gunsInfo);
    }
}