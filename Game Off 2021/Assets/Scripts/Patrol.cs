using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public float speed;
    public float distance;

    private bool movingRight = true;
    public Transform groundDetection;
    public LayerMask whatIsGround;
    public float dazedTime;
    public float startDazedTime;

    void Update()
    {
        if (dazedTime <= 0)
        {
            speed = 3;
        }
        else
        {
            speed = 0;
            dazedTime -= Time.deltaTime;
        }



        transform.Translate(Vector2.right * speed * Time.deltaTime);

        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, distance, whatIsGround);
        if (groundInfo.collider == false)
        {
            if (movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;

            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
        }
    }
}
