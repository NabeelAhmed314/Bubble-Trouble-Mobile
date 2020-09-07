using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void OnSinglePlayButtonClicked()
    {
        Debug.Log("Single Player");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void onMainMenuClicked()
    {
        SceneManager.LoadScene(0);
    }
    public void onRetryClicked()
    {
        SceneManager.LoadScene(1);
    }
    public void OnMultiplayerPlayButtonClicked()
    {
        Debug.Log("Multi Player");
/*        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);*/
    }
    public void OnQuitButtonClicked()
    {
/*        UnityEditor.EditorApplication.isPlaying = false;*/
        Application.Quit();
    }
}
