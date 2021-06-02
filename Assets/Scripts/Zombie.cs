using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Zombie : MonoBehaviour
{
    float Dist;
    public Animator animator;
    GameObject PlayerTarget;
     public  NavMeshAgent agent;

    public AudioSource attackingSound;
    float AttackTime = 0;
    float AttackCd = 2;
    private void Start()
    {

       
        PlayerTarget = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        Dist = Vector3.Distance(transform.position, PlayerTarget.transform.position);

        if (Dist < 4)
            {
                animator.SetBool("Running", false);
                StopEnemy();
                if (Time.time - AttackTime >= AttackCd)

                {
                    AttackTime = Time.time;
                    PlayerTarget.GetComponent<PlayerHealth>().TakeDamege(10);
                    attackingSound.Play();
                    animator.SetBool("Attacking", true);
                }


            }

            else {
                animator.SetBool("Attacking", false);
                FindPlayer(); }


            if (transform.position.x > 0)
            {
             
                animator.SetBool("Running", true);

            }
        

    } 
    private void FindPlayer()
    {
      
            agent.isStopped = false;
            agent.SetDestination(PlayerTarget.transform.position);
        
        

    }
    private void StopEnemy()
    {
        agent.isStopped = true;
    }
}
