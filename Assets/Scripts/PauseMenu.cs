using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }

    public void OnRestartScene()
    {
        var currentScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(currentScene);
    }

    public void OnReturnMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void OnContinue()
    {
        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        Time.timeScale = 1;
    }
}
