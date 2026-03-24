using UnityEngine;

public class AuthorsButton : MonoBehaviour
{
    [SerializeField] private MainMenu _mainMenu;
    [SerializeField] private AuthorsWindow _authorsWindow;

    public void OpenWindow()
    {
        _mainMenu.gameObject.SetActive(false);
        _authorsWindow.gameObject.SetActive(true);
    }
}