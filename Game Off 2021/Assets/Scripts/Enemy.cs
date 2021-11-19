using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    private Patrol patrol;
    public GameObject deathEffect;
    AudioSource audioSource;
    public AudioClip damageClip;


    private void Start()
    {
        patrol = GetComponent<Patrol>();
        audioSource = GetComponent<AudioSource>();
    }
    public void Update()
    {

        if (health <= 0)
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);


        }
    }


    public virtual void TakeDamage(int damage)
    {
        patrol.dazedTime = patrol.startDazedTime;
        health -= damage;
        Debug.Log("damage taken");
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
            audioSource.PlayOneShot(damageClip);
        }
    }

}
