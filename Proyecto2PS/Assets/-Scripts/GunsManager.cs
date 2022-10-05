using UnityEngine;
public class GunsManager : MonoBehaviour
{
    [SerializeField] private ScriptableObject Gun = default;
    public static GunsManager instance { get; private set; }

    private void Awake()
    {
        if(instance != null && instance != this)
        {
            Destroy(this);
        }else
        {
        instance = this;
        }
    }

    public void SetGun(ScriptableObject scriptableObject)
    {
        Gun = scriptableObject;
        Debug.Log("Se puso el arma");
        Player.instance.SetGun(instance);
    }  
}