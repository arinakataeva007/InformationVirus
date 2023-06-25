using UnityEngine;
using UnityEngine.SceneManagement;

public class Skip : MonoBehaviour
{
    private void Update()
    {
        if (SkipCutScene())
            SceneManager.LoadScene(1);
    }

    private static bool SkipCutScene()
    {
        return Input.GetKeyDown(KeyCode.Space)
               || Input.GetKeyDown(KeyCode.Escape)
               || Input.GetKeyDown(KeyCode.Backspace)
               || Input.GetMouseButtonDown(0);
    }
}
