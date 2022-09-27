using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float SpeedMov;
    GunsManager gunsInfo1;
    [SerializeField] private ScriptableObject Gun1;
   [SerializeField] Camera cam;
    [SerializeField] Rigidbody2D rigidb2d;
    Vector2 movementRigid2d;
    Vector2 mousePosition;

    // Existe un unico jugador por lo que lo instanciamos
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
        // movimiento del jugador
        float MovementY = Input.GetAxisRaw("Vertical") * SpeedMov * Time.deltaTime;
        float MovementX = Input.GetAxisRaw("Horizontal") * SpeedMov * Time.deltaTime;

        

        transform.Translate(new Vector2(MovementX, 0f));
        transform.Translate(new Vector2(0f, MovementY));

        // recibe la posicion del mouse 
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    private void FixedUpdate()
    {
        // el rigidbody gira en direccion donde apunta el mouse
        rigidb2d.MovePosition(rigidb2d.position + movementRigid2d * SpeedMov * Time.fixedDeltaTime);
        Vector2 lookDirection = mousePosition - rigidb2d.position;
        float angle = Mathf.Atan2(lookDirection.y, lookDirection.x) * Mathf.Rad2Deg - 90f;
        rigidb2d.rotation = angle;

    }

    private void OnTriggerEnter(Collider other)
    {
        // recibir el arma al tocar el arma 
        SetGun(gunsInfo1);
    }


    public void SetGun(GunsManager gunsInfo)
    {
        // traer los atributos del Gunsmanager
        gunsInfo1 = gunsInfo;
       Instantiate(gunsInfo, transform);
    }

   



}
