using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Control para menu de pausa. Se encuentra en escena
/// y tiene un objeto hijo con todos los elementos de ui
/// que se activan/desactivan
/// </summary>
public class PauseMenuController : MonoBehaviour
{
    // Juan Lanosa

    public static PauseMenuController instance;

    public GameObject pauseWindowContainer;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(instance);
        }

        instance = this;
    }
    public void TogglePauseState()
    {
        bool shouldPause = !pauseWindowContainer.activeSelf;
        // pause on => shouldPause = false

        pauseWindowContainer.SetActive(shouldPause);

        if (!shouldPause)
        {
            Time.timeScale = 1;
        }
        else
        {
            Time.timeScale = 0;
        }
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Constants.MAIN_MENU_BUILD_IDX);
    }
}
