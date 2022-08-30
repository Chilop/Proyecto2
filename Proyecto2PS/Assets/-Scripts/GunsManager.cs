 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsManager : MonoBehaviour
{
    //[SerializeField] private List<ScriptableObject> ;
    [SerializeField] private ScriptableObject Gun;
    //[SerializeField] private ScriptableObject Gun2;


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

        
    }


    // Start is called before the first frame update
    /*
    void Start()
    {
        
    }
    */
    // Update is called once per frame
    /*
    void Update()
    {
        
    }
    */
}
