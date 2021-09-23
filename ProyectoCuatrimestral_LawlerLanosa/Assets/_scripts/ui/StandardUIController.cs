using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandardUIController : MonoBehaviour
{
    public void PauseGame()
    {
        PauseMenuController.instance.TogglePauseState();
    }
}
