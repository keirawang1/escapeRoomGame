using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    public string gameSceneName = "room1";
    
    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene(gameSceneName);
    }
}
