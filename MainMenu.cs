using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void LoadToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
