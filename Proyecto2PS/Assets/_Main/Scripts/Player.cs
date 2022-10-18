using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance { get; private set; }

    [SerializeField] private float _speed = default;
    [SerializeField] private Rigidbody2D _rigidbody2D = default;
    [SerializeField] private Camera _camera = default;
    [SerializeField] private Joystick _joystick = null;
    private Vector2 _mousePosition = default;
    private Vector2 _movement = default;
    private GameObject _currentWeapon = default;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
        }
    }

    void Update()
    {
        _movement.x = _joystick.Horizontal * _speed;
        _movement.y = _joystick.Vertical * _speed;
        _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        _rigidbody2D.MovePosition(_rigidbody2D.position + _movement * Time.fixedDeltaTime);
        Vector2 lookdirection = _mousePosition - _rigidbody2D.position;
        float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        _rigidbody2D.rotation = angle; 
    }

    public void SetGun(GunsInfo gunsInfo)
    {
        if (_currentWeapon != null)
        {
            Destroy(_currentWeapon);
        }

        _currentWeapon = Instantiate(gunsInfo.Weapon, transform.position, transform.rotation, transform);
    }

}
