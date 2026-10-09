using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadMiniGame1()
    {
        SceneManager.LoadScene("MiniGame1");
    }

    public void LoadMiniGame2()
    {
        SceneManager.LoadScene("MiniGame2");
    }

    public void LoadMiniGame3()
    {
        SceneManager.LoadScene("MiniGame3");
    }

    public void Quit()
    {
        Application.Quit();
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}
