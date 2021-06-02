using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    
    public float fireRate = 1f;
    private float nextbullet = 0f;

    public GameObject impactEffect;
    public ParticleSystem muzzzzflash;
    public AudioSource shootSounds;
    public Animator animator;
   


    private void Start()
    {
        shootSounds = GetComponent<AudioSource>();
        
    }
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextbullet)
        {
            animator.SetTrigger("isFire");
            shootSounds.Play();
            nextbullet = Time.time + fireRate;
            shoot();

        }
    }
    void shoot()
    {
        muzzzzflash.Play();

        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamege(damage);
            }

            GameObject impact = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impact, 1f);
        }
    }   
}
