using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;

public class UIPickupGun : MonoBehaviour
{
    private GunsInfo gunsinfo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonPickGunup()
    {
        GunsManager.instance.SetGun(gunsinfo);

        
    }

    public void ButtonKeepGun()
    {
        if (gunsinfo != null)
        {
            
        }
        else
        {

        }
        
    }

}
