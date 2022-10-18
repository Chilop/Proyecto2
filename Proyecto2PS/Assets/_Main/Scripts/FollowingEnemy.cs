using UnityEngine;

public class FollowingEnemy : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = default;
    [SerializeField] private GameObject _targetPlayer = default;

    private Rigidbody2D _enemyRigidbody2D = null;
    private Vector2 _movement = default;

    void Start()
    {
        _targetPlayer = GameObject.Find("Player");
        _enemyRigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 _direction = _targetPlayer.transform.position - transform.position;
        float _angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        _enemyRigidbody2D.rotation = _angle;
        _direction.Normalize();
        _movement = _direction;
    }

    private void FixedUpdate()
    {
        MoveEnemy(_movement);
    }

    void MoveEnemy(Vector2 direction)
    {
        _enemyRigidbody2D.MovePosition((Vector2)transform.position + (direction * _enemySpeed * Time.deltaTime));
    }
}
