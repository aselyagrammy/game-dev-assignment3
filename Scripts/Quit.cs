using UnityEngine;
using UnityEngine.UI;

public class QuitGame : MonoBehaviour
{
    private Button quitButton;

    void Start()
    {
        // Find the "QuitButton" dynamically and get its Button component
        quitButton = GameObject.Find("QuitButton").GetComponent<Button>();

        // Add a listener to the button
        quitButton.onClick.AddListener(ExitGame);
    }

    public void ExitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();

        // NOTE: If testing in the Unity Editor, stop play mode
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}
