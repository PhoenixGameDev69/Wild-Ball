using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject _pauseWindowPrefab;
    [SerializeField] private GameObject _restartWindowPrefab;

    private Canvas _sceneCanvas;

    private void Awake()
    {
        _sceneCanvas = FindObjectOfType<Canvas>();
    }

    public void OnOpenPauseWindow()
    {
        Instantiate(_pauseWindowPrefab, _sceneCanvas.transform);
    }

    public void OnRestartWindow()
    {
        Instantiate(_restartWindowPrefab, _sceneCanvas.transform);
    }

    public void OnSceneLaunch(int id)
    {
        SceneManager.LoadScene(id);
    }
}
