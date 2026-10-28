using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Canvas GameMenu;
    private bool isShowingMenu = false;

    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton;
    public Button RestartButton;

    private void Start()
    {
        // Menu is hidden by default; it is shown by EnterGame when the plane hits the wall.
        GameMenu.enabled = isShowingMenu;

        // Popup content is loaded from code.
        Title.text = "Welcome to Unity!";
        Message.text = "Do you want to continue?";
        ContinueButton.GetComponentInChildren<TMP_Text>().text = "Continue";
        RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    public void ShowMenu()
    {
        isShowingMenu = true;
        GameMenu.enabled = true;
        Time.timeScale = 0f; // freeze the scene behind the popup
    }

    public void NextScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_Scene_1");
    }

    public void RestartScene()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("_Scene_3_2");
    }
}
