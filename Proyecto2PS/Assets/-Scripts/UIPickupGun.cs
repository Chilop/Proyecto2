using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline.Actions;
using UnityEngine;
using UnityEngine.UI;

public class UIPickupGun : MonoBehaviour
{
   // GameObject weapon;


    GunsInfo gunsinfo;
    [SerializeField] GameObject Menupick;
    // Start is called before the first frame update
    void Start()
    {
        Menupick.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
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
