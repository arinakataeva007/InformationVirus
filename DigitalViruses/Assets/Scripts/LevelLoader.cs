using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Button keylogger;

    private int _levelComplete;

    private void Start()
    {
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");

        keylogger.interactable = _levelComplete switch
        {
            1 => true,
            _ => false
        };
    }

    public void LoadLevel(int level) => SceneManager.LoadScene(level);
}
