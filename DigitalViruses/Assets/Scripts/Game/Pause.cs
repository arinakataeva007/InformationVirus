using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private bool _isPaused;
    
    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject game;
    
    private void Update()
    {
        if (_isPaused)
            PauseGame();
        
        else
            ResumeGame();
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        game.SetActive(false);
        
        Time.timeScale = 0f;
        _isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        game.SetActive(true);
        
        Time.timeScale = 1f;
        _isPaused = false;
    }
    
    public void MainMenu()
    {
        _isPaused = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }
}
