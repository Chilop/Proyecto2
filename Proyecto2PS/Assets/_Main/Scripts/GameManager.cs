using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool _endGame = false;
   [SerializeField] private GameObject _gameOverUI = null;

    private void Start()
    {
        SearchGameOverUI();
    }
    public void EndGame()
    {
        if (_endGame == false)
        {
            _endGame = true;
            _gameOverUI.SetActive(true);
            StartCoroutine(GoBackToMainMenu());
        Debug.Log("Game OVA");
        }
    }

    public void SearchGameOverUI()
    {
        _gameOverUI = GameObject.Find("GameOverUI");
        _gameOverUI.SetActive(false);
    }

    IEnumerator GoBackToMainMenu()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("MainMenu");
    }
}
