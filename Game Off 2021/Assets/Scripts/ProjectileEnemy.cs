using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileEnemy : Enemy
{
    public GameObject projectile;
    public Transform shootPos;
    private float timeBtwShots;
    public float startTimeBtwShots;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            Instantiate(projectile, shootPos.position, transform.rotation);
            timeBtwShots = startTimeBtwShots;
            
        }
        else
        {
            timeBtwShots -= Time.deltaTime;
        }
        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);


        }
    }

    public override void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("damage taken");
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
        }
    }
}
