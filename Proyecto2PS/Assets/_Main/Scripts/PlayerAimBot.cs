using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimBot : MonoBehaviour
{
    private Rigidbody2D _playerRigidbody2D = null;
    private GameObject _enemy = null;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookdirection = _enemy.transform.position - transform.position;
        float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        _playerRigidbody2D.transform.rotation = rotation;
    }
}
