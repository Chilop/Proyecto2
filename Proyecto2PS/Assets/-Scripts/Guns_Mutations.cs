using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guns_Mutations : MonoBehaviour
{
    [SerializeField] GunsInfo gunsinfo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gunsinfo.MutationName);
        Debug.Log(gunsinfo.description);
        Debug.Log(gunsinfo.damage);

        GunsManager.instance.SetGun(gunsinfo);

        Destroy(gameObject);
    }
    
        
   

}
