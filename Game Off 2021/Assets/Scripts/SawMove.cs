using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SawMove : MonoBehaviour
{
    public float speed = 5.0f;
    public int yPos = 1;
    public int xPos = 0;
    AudioSource audioSource;
    public AudioClip damageClip;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xPos, yPos, 0) * Time.deltaTime * speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            speed *= -1;
        }

        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            player.ChangeHealth(-1);
            audioSource.PlayOneShot(damageClip);
        }
    }
}
