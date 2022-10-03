using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SpeedMov;
    GunsManager gunsInfo1;
    [SerializeField] private ScriptableObject Gun1;
    Vector2 mouseposition;
    Vector2 movement;
    [SerializeField] private Rigidbody2D rigidbd2D;
    [SerializeField] private Camera cam;

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

        movement.y = Input.GetAxis("Vertical") * SpeedMov;
        movement.x = Input.GetAxis("Horizontal") * SpeedMov; 

        /* 
         * haciendo la correcion con time.deltatime;
            MovementX *= Time.deltaTime;
            MovementY *= Time.deltaTime;
        */

        // poniendo lo que creamos para el transform para que se mueva

       // transform.Translate(new Vector2(MovementX, 0f));
       // transform.Translate(new Vector2(0f, MovementY));

        mouseposition = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        rigidbd2D.MovePosition(rigidbd2D.position + movement * Time.fixedDeltaTime);

        Vector2 lookdirection = mouseposition - rigidbd2D.position;
        float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        rigidbd2D.rotation = angle;
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
