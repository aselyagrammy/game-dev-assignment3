using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public string sceneName = "SampleScene"; // Set the name of the scene
    private Button startButton;

    void Start()
    {
        // Find the "StartButton" dynamically and get its Button component
        startButton = GameObject.Find("StartButton").GetComponent<Button>();

        // Add a listener to the button
        startButton.onClick.AddListener(LoadGameScene);
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
