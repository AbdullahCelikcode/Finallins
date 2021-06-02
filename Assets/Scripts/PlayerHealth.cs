
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float healt = 100;
    public Text Can;
    public void TakeDamege(float amounth)
    {  
        healt -= amounth;
        if (healt <= 0)
        {
            Die();
        }
        Can.text = healt.ToString("0");
    }
    void Die()
    {
        Cursor.lockState = CursorLockMode.Confined;
        SceneManager.LoadScene(0);

    }

}
