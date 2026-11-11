using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangerScript : MonoBehaviour
{
    public void Startgame()
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1f;
    }
    public void Playgame()
    {
        SceneManager.LoadSceneAsync(1);
    }
    
    public void GameWon()
    {
        SceneManager.LoadSceneAsync(2);
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
