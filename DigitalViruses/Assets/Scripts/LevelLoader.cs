using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private Button rootKit;

    private int _levelComplete;

    private void Start()
    {
        _levelComplete = PlayerPrefs.GetInt("LevelComplete");

        rootKit.interactable = _levelComplete switch
        {
            1 => true,
            _ => false
        };
    }

    public void LoadLevel(int level) => SceneManager.LoadScene(level);
}
