using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioSource audio;


    private void Start()
         
    {
        audio.Play();
    }
    private void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;

        
    }
    public  void Playgame() {
        audio.Stop();
        Cursor.lockState = CursorLockMode.Locked;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
public void QuitGame()
    {
        Application.Quit();

    }

}
