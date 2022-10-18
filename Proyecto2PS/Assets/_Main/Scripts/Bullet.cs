using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _bulletspeed = 0.1f;

    void Update()
    {
        transform.position += transform.up * _bulletspeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
