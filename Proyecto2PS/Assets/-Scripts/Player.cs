using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SpeedMov;
    GunsManager gunsInfo1;
    [SerializeField] private ScriptableObject Gun1;

    public static Player instance { get; private set; }

    private void Awake()
    {
        if (instance != null && instance !=this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    void Update()
    {

        // creando la funcion de movimiento
        //transform.Translate(new Vector2(0f, SpeedMov) * Time.deltaTime);
        // vamos a usar para el movimiento un input.getaxis

        float MovementY = Input.GetAxis("Vertical") * SpeedMov * Time.deltaTime;
        float MovementX = Input.GetAxis("Horizontal") * SpeedMov * Time.deltaTime;

        /* 
         * haciendo la correcion con time.deltatime;
            MovementX *= Time.deltaTime;
            MovementY *= Time.deltaTime;
        */

        // poniendo lo que creamos para el transform para que se mueva

        transform.Translate(new Vector2(MovementX, 0f));
        transform.Translate(new Vector2(0f, MovementY));


    }

    private void OnTriggerEnter(Collider other)
    {
        SetGun(gunsInfo1);
    }


    public void SetGun(GunsManager gunsInfo)
    {
        gunsInfo1 = gunsInfo;
       Instantiate(gunsInfo, transform);
    }

   



}
