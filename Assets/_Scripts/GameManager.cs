using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _pauseWindowPrefab;

    private Canvas _sceneCanvas;

    private void Awake()
    {
        _sceneCanvas = FindObjectOfType<Canvas>();
    }

    public void OnOpenPauseWindow()
    {
        Instantiate(_pauseWindowPrefab, _sceneCanvas.transform);
    }

    public void OnSceneLaunch(int id)
    {
        SceneManager.LoadScene(id);
    }
}
