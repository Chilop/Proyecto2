using UnityEngine;
public class FollowingEnemie : MonoBehaviour
{
    [SerializeField] private float _enemyspeed = default;
    [SerializeField] public Transform _target = default;
    void Update()
    {
        if (Vector2.Distance(transform.position, _target.position) > _enemyspeed)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, _enemyspeed * Time.deltaTime);
        }
        else
        {

        }
    }
}