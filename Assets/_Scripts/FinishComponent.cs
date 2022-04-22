using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishComponent : MonoBehaviour
{
    [SerializeField] private GameObject _blackout;

    private Animator _blackoutAnimator;

    private void Awake()
    {
        _blackoutAnimator = GetComponent<Animator>();
        _blackout.SetActive(true);
    }

    private void OnCollisionEnter(Collision collision)
    {
        _blackoutAnimator.SetTrigger("End");
    }

    public void OnNextLevel()
    {
        var nextLevel = SceneManager.GetActiveScene().buildIndex + 1;

        if (SceneManager.sceneCountInBuildSettings > nextLevel)
            SceneManager.LoadScene(nextLevel);
    }
}
