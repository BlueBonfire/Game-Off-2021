using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPanel;
    public void Menu()
    {
        SceneManager.LoadScene(2);
    }
    public void PanelClose()
    {
        menuPanel.gameObject.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            //LoadPlayer();
            SceneManager.LoadScene(3);
        }
    }
}
