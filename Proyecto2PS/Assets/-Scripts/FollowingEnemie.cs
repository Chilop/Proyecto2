using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingEnemie : MonoBehaviour
{
    [SerializeField] private float enemyspeed;
    [SerializeField] public Transform target;
    public float mininumDistance;
    void Update()
    {
        if(Vector2.Distance(transform.position,target.position) > enemyspeed)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, enemyspeed* Time.deltaTime);
        }
        else
        {

        }
    }
}
