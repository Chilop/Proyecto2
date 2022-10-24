
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerAimBot : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemyList;
    [SerializeField] private int _aimRange = default;
    private GameObject _objectToFollow = default;
    private CircleCollider2D _circleCollider2D = default;
    private Rigidbody2D _playerRigidbody2D = null;
    private void Start()
    {
        _playerRigidbody2D = GetComponent<Rigidbody2D>();
        _circleCollider2D = GetComponent<CircleCollider2D>();
        _circleCollider2D.radius = _aimRange;
    }

    void Update()
    {
        if (_enemyList.Count == 0) return;
        
        LookEnemy();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;

        _enemyList.Add(collision.gameObject);

        if (_enemyList.Count != 1) return;

        Retarget();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;

        _enemyList.Remove(collision.gameObject);

        Retarget();
    }

    private void Retarget()
    {
        _objectToFollow = _enemyList.FirstOrDefault();
    }   

    private void LookEnemy()
    {
        Vector2 lookdirection = _enemyList.FirstOrDefault().transform.position - transform.position;
        float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        _playerRigidbody2D.transform.rotation = rotation;
    }
}
