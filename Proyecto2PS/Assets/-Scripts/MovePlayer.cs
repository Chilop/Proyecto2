using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float SpeedMov;

    // Start is called before the first frame update
    // by the moment i'm noy using void start
    /*
    void Start()
    {
        
    }
    */



    // Update is called once per frame
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
}
