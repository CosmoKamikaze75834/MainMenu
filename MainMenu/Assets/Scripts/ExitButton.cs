using UnityEngine;

public class ExitButton : MonoBehaviour
{
    [SerializeField] private CanvasGroup _canvasGroup;

    private bool _isExiting = false;

    public void StartExit()
    {
        if(_isExiting)
            return;

        _isExiting = true;

        _canvasGroup.interactable = false;
        _canvasGroup.blocksRaycasts = false;
    }

    public void CompleteGame()
    {
        Application.Quit();
    }
}