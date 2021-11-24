using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public GameObject block;
    public GameObject warningMsg;
    public GameObject msg;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            block.gameObject.SetActive(false);
            Destroy(gameObject);
        }
        warningMsg.gameObject.SetActive(false);
        msg.gameObject.SetActive(true);

        
    }
}
