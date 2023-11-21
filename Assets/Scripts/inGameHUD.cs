using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameHUD : MonoBehaviour
{

    public GameObject pauseMenu;
    public void OpenPauseMenu()
    {
        pauseMenu.SetActive(true);
    }

    public void ClosePauseMenu() 
    {
        pauseMenu.SetActive(false);
    }    
}
