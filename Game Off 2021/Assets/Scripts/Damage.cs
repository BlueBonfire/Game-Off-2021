using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    AudioSource audioSource;
    public AudioClip damageClip;



    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        PlayerController controller = other.GetComponent<PlayerController>();

        if (controller != null)
        {
            controller.ChangeHealth(-1);
            audioSource.PlayOneShot(damageClip);
        }
        
    }
}
