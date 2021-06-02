using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameisPaused = false;
    public GameObject pauseMenuUI;
    public GameObject Crosshair;
    public GameObject Score;
    public GameObject Health;
   
    
    void Update()
    {

       

        if (Input.GetKeyDown    (KeyCode.Escape))
        {
           
            if(GameisPaused)
            {
                Resume();

            }
            else
            {
                Pause();
            }
            

        }

        

    }
   public void Resume()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Crosshair.SetActive(true);
        Score.SetActive(true);
        Health.SetActive(true);
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1;
       
        GameisPaused = false;
       

    }

    void Pause()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        pauseMenuUI.SetActive(true);
        Crosshair.SetActive(false);
        Score.SetActive(false);
        Health.SetActive(false);
        Time.timeScale = 0;
       
        GameisPaused = true;

    }

   
    public void QuitGame()
    {
        Application.Quit();

    }

}
