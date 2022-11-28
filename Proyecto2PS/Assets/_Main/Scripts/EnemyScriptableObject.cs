
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Scriptable Object", menuName = "Enemy data")]
public class EnemyScriptableObject : ScriptableObject
{
    [SerializeField] private int _health = default;
    [SerializeField] private int _damage = default;
    [SerializeField] private float _speed = default;
    [SerializeField] private int _scorePoints = default;
    [SerializeField] private GameObject _enemy = default;

    public int Health => _health;

    public int Damage => _damage;

    public float Speed => _speed;

    public int ScorePoints => _scorePoints;

    public GameObject Enemy => _enemy; 
}
