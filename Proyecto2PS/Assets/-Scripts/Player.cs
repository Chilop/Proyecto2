using UnityEngine;
public class Player : MonoBehaviour
{
    [SerializeField] private float _SpeedMov = default;
    [SerializeField] GunsManager gunsInfo1 = default;
    Vector2 _mouseposition = default;
    Vector2 _movement = default;
    [SerializeField] private Rigidbody2D _rigidbd2D = default;
    [SerializeField] private Camera _cam = default;
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
        _movement.y = Input.GetAxis("Vertical") * _SpeedMov;
        _movement.x = Input.GetAxis("Horizontal") * _SpeedMov; 
        _mouseposition = _cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void FixedUpdate()
    {
        _rigidbd2D.MovePosition(_rigidbd2D.position + _movement * Time.fixedDeltaTime);
        Vector2 lookdirection = _mouseposition - _rigidbd2D.position;
        float angle = Mathf.Atan2(lookdirection.y, lookdirection.x) * Mathf.Rad2Deg - 90f;
        _rigidbd2D.rotation = angle;
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
