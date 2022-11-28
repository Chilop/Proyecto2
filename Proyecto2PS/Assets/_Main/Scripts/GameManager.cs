using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    private bool _endGame = false;
    [SerializeField] private GameObject _gameOverUI = null;
    [SerializeField] private GameObject _player = null;
    public GameObject Player => _player;

    private void Start()
    {
        SearchGameOverUI();
    }

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

    public void EndGame()
    {
        if (_endGame == false)
        {
            _endGame = true;
            _gameOverUI.SetActive(true);
            StartCoroutine(GoBackToMainMenu());
        }
    }

    public void SearchGameOverUI()
    {
        _gameOverUI.SetActive(false);
    }

    private IEnumerator GoBackToMainMenu()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
