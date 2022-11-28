using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScorePoints : MonoBehaviour
{
    public int enemyPointsObtained { get; private set; }
    [SerializeField] private EnemyScriptableObject _enemyScriptableObject = null;

    void Start()
    {
        SetScoreObtained(_enemyScriptableObject.ScorePoints);
    }

    public void SetScoreObtained(int enemyScorePoints)
    {
        enemyPointsObtained = enemyScorePoints;
    }
}
