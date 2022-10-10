using UnityEngine;
public class FollowingEnemy : MonoBehaviour
{
    [SerializeField] private float _enemySpeed = default;
    [SerializeField] private Transform _targetPlayer = default;

    private Rigidbody2D _enemyRigidbody2D = null;
    private Vector2 _movement = default;

    void Start()
    {
        _enemyRigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector3 _direction = _targetPlayer.position - transform.position;
        float _angle = Mathf.Atan2(_direction.y, _direction.x) * Mathf.Rad2Deg;
        _enemyRigidbody2D.rotation = _angle;
        _direction.Normalize();
        _movement = _direction;
    }

    private void FixedUpdate()
    {
        moveEnemy(_movement);
    }

    void moveEnemy(Vector2 _direction)
    {
        _enemyRigidbody2D.MovePosition((Vector2)transform.position + (_direction * _enemySpeed * Time.deltaTime));
    }
}
