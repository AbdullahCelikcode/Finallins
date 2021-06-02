using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public float Puan = 0;
    public  Text PuanSayisi;
    public AudioSource audio;
   
    // Start is called before the first frame update
    void Start()
    {
        audio.Play();
        Puan = 0;
        UpdateScoreUI();    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void AddScore(float amount)
    {
        Puan += amount;
        UpdateScoreUI();

    }

    private  void UpdateScoreUI()
    {

        PuanSayisi.text = Puan.ToString("0");
    }
}
