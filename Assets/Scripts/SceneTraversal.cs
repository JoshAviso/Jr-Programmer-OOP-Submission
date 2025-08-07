using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTraversal : MonoBehaviour
{
    [SerializeField] private string _mainMenuScene;
    [SerializeField] private string _demoScene;
    public void GoToMainMenu()
    {
        if (String.IsNullOrEmpty(_mainMenuScene)) return;
        SceneManager.LoadScene(_mainMenuScene);
    }
    public void GoToDemo()
    {
        if (String.IsNullOrEmpty(_demoScene)) return;
        SceneManager.LoadScene(_demoScene);
    }
}
