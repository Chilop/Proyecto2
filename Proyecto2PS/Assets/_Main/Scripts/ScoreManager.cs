using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance { get; private set; }
    [SerializeField] private TextMeshProUGUI _scoreText = default;
    [SerializeField] private TextMeshProUGUI _highScoreText = default;
    private int _scorePoints = default;
    public int ScorePoints => _scorePoints;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        InitializeHighScore();
        _scorePoints = 0;
    }

    void Update()
    {
        _scoreText.text = _scorePoints.ToString();

        if (_scorePoints > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", _scorePoints);
            _highScoreText.text = _scorePoints.ToString();
        }
    }

    public void InitializeHighScore()
    {
        _highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    public void ScoreValue(int points)
    {
        _scorePoints += points;
    }
}
