using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private string _sceneName;

    public void LoadGameScene()
    {
        SceneManager.LoadScene(_sceneName);
    }
}
