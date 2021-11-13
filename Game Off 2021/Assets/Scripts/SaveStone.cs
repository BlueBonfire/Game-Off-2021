using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveStone : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        PlayerController player = other.gameObject.GetComponent<PlayerController>();

        if (player != null)
        {
            player.SavePlayer();
        }
    }
}
