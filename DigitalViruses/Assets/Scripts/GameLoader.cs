using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLoader : MonoBehaviour
{
    private void Start() => Invoke(nameof(LoadMainMenu), 2f);

    private void LoadMainMenu() => SceneManager.LoadScene(1);
}
