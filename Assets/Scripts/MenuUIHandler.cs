using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class MenuUIHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField input;
    public void HandleStart()
    {
        //ABSTRACTION
        HandleInput();
        SceneManager.LoadScene(1);
    }
    private void HandleInput()
    {
        if (input.text == "")
        {
            MenuManager.Instance.playerName = "Guest";
        }
        else
        {
            MenuManager.Instance.playerName = input.text;
        }
    }
}
