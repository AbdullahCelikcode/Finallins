
using UnityEngine;
using UnityEngine.AI;

public class Target : MonoBehaviour
{
    public float healt=50f;
    public Animator animator;
    private float score = 10;
    GameController gameController;
    Spawner spawner;
   
    private void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        spawner= GameObject.FindGameObjectWithTag("Spawner").GetComponent<Spawner>();
    }

    public void TakeDamege(float amounth){

        healt-=amounth;
        if (healt<=0)
        {
            
            Die();
        }
    }

void Die(){ 
       
        gameController.AddScore(score);
       
        spawner.killedenemy++;
        
        Destroy(gameObject);
        
        }

    }


