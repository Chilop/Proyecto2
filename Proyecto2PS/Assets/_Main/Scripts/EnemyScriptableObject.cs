
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Scriptable Object", menuName = "Enemy data")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] private int health = default;
    [SerializeField] private int damage = default;
    [SerializeField] private float speed = default;
    [SerializeField] private int scorePoints = default;
    [SerializeField] private GameObject enemy = default;

    public int Health => health;

    public int Damage => damage;

    public float Speed => speed;

    public int ScorePoints => scorePoints;

    public GameObject Enemy => enemy; 
}
