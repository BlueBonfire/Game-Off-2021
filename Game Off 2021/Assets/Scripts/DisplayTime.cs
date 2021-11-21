using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTime : MonoBehaviour
{
    public GameObject theDisplay;
    public int hour;
    public int minutes;
    string m;
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        hour = System.DateTime.Now.Hour;
        minutes = System.DateTime.Now.Minute;
        m = minutes.ToString();
        theDisplay.GetComponent<Text>().text = "" + hour + ":" + m;
    }
}
