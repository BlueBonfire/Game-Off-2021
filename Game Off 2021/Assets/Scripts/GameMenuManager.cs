using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public GameObject start;
    public GameObject howToPlay;
    public GameObject exit;
    public GameObject title;
    public GameObject tutorial;
    public GameObject back;
    public GameObject Page2;
    public GameObject Page1;



    public void StartGame()
    {
        SceneManager.LoadScene(3);
    }
    public void ExitGame()
    {
        SceneManager.LoadScene(1);
    }
    public void HowToPlay()
    {
        start.gameObject.SetActive(false);
        exit.gameObject.SetActive(false);
        howToPlay.gameObject.SetActive(false);
        tutorial.gameObject.SetActive(true);
        title.gameObject.SetActive(false);
        back.gameObject.SetActive(true);
    }
    public void Back()
    {
        start.gameObject.SetActive(true);
        exit.gameObject.SetActive(true);
        howToPlay.gameObject.SetActive(true);
        tutorial.gameObject.SetActive(false);
        title.gameObject.SetActive(true);
        back.gameObject.SetActive(false);
    }
    public void Next()
    {
        Page1.gameObject.SetActive(false);
        Page2.gameObject.SetActive(true);
    }
    public void Prev()
    {
        Page1.gameObject.SetActive(true);
        Page2.gameObject.SetActive(false);
    }
}
