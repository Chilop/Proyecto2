using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Guns_Mutations : MonoBehaviour
{
    [SerializeField] GunsInfo gunsinfo;
    [SerializeField] GameObject MenuPickupGun;

    void Start()
    {
        MenuPickupGun.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(gunsinfo.MutationName);
        Debug.Log(gunsinfo.description);
        Debug.Log(gunsinfo.damage);

        MenuPickupGun.SetActive(true);



        // esta linea hace que al recojer el arma, esta mande sus elementos al Gun manager

       // GunsManager.instance.SetGun(gunsinfo);

       // Destroy(gameObject);
    }
    
        
   

}
