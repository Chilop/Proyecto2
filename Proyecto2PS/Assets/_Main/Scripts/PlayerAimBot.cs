
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PlayerAimBot : MonoBehaviour
{
    [SerializeField] private List<GameObject> _enemylist = new List<GameObject>(0);
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
        Vector2 lookdirection = _enemylist.FirstOrDefault().transform.position - transform.position;
        float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        _playerRigidbody2D.transform.rotation = rotation;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;

        _enemylist.Add(collision.gameObject);

        if (_enemylist.Count != 1) return;

        Retarget();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;

        _enemylist.Remove(collision.gameObject);

        Retarget();
    }

    private void Retarget()
    {
        _objectToFollow = _enemylist.FirstOrDefault();
    }
}
