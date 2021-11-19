using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class StartButton : MonoBehaviour
{
    public GameObject start;
    public GameObject startIcon;
    public GameObject folder;
    public GameObject folderIcon;
    public GameObject mail;
    public GameObject mailIcon;
    public GameObject mailTxt1;
    public GameObject mailTxt2;
    public GameObject mailTxt3;
    public GameObject mailTxt4;
    public GameObject folderTxt1;
    public GameObject folderTxt2;
    public GameObject folderTxt3;
    public GameObject folderTxt4; 
    public GameObject folderTxt5;
    public GameObject folderTxt6;
    public GameObject infoFolderTxt;

    private bool _AlreadyClicked = false;

    AudioSource audioSource;
    public AudioClip clickClip;


    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            audioSource.PlayOneShot(clickClip);
        }
    }


    public void InfoFolderTxtOpen()
    {
        infoFolderTxt.gameObject.SetActive(true);
        folder.gameObject.SetActive(true);
        mail.gameObject.SetActive(false);
        mailIcon.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        mailTxt4.gameObject.SetActive(false);
        mailTxt2.gameObject.SetActive(false);
        mailTxt3.gameObject.SetActive(false);
        mailTxt1.gameObject.SetActive(false);
    }

    public void FolderTxt1Open()
    {
        folderTxt1.gameObject.SetActive(true);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
    }
    public void FolderTxt2Open()
    {
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(true);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
    }
    public void FolderTxt3Open()
    {
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(true);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
    }
    public void FolderTxt4Open()
    {
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(true);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
    }
    public void FolderTxt5Open()
    {
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(true);
        folderTxt6.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
    }
    public void FolderTxt6Open()
    {
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(true);
        folderIcon.gameObject.SetActive(false);
    }




    public void MailTxt1Open()
    {
        mailTxt1.gameObject.SetActive(true);
        mailTxt2.gameObject.SetActive(false);
        mailTxt3.gameObject.SetActive(false);
        mailTxt4.gameObject.SetActive(false);
    }
    public void MailTxt2Open()
    {
        mailTxt2.gameObject.SetActive(true);
        mailTxt1.gameObject.SetActive(false);
        mailTxt3.gameObject.SetActive(false);
        mailTxt4.gameObject.SetActive(false);
    }
    public void MailTxt3Open()
    {
        mailTxt3.gameObject.SetActive(true);
        mailTxt1.gameObject.SetActive(false);
        mailTxt2.gameObject.SetActive(false);
        mailTxt4.gameObject.SetActive(false);
    }
    public void MailTxt4Open()
    {
        mailTxt4.gameObject.SetActive(true);
        mailTxt2.gameObject.SetActive(false);
        mailTxt3.gameObject.SetActive(false);
        mailTxt1.gameObject.SetActive(false);
    }


    public void FolderOpen()
    {
        folder.gameObject.SetActive(true);
        folderIcon.gameObject.SetActive(true);
        mail.gameObject.SetActive(false);
        mailIcon.gameObject.SetActive(false);
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        infoFolderTxt.gameObject.SetActive(false);
        mailTxt4.gameObject.SetActive(false);
        mailTxt2.gameObject.SetActive(false);
        mailTxt3.gameObject.SetActive(false);
        mailTxt1.gameObject.SetActive(false);
    }

    public void FolderClose()
    {
        folder.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        infoFolderTxt.gameObject.SetActive(false);
    }



    public void MailOpen()
    {
        mail.gameObject.SetActive(true);
        mailIcon.gameObject.SetActive(true);
        folder.gameObject.SetActive(false);
        folderIcon.gameObject.SetActive(false);
        folderTxt1.gameObject.SetActive(false);
        folderTxt2.gameObject.SetActive(false);
        folderTxt3.gameObject.SetActive(false);
        folderTxt4.gameObject.SetActive(false);
        folderTxt5.gameObject.SetActive(false);
        folderTxt6.gameObject.SetActive(false);
        infoFolderTxt.gameObject.SetActive(false);
    }

    public void MailClose()
    {
        mail.gameObject.SetActive(false);
        mailIcon.gameObject.SetActive(false);
        mailTxt4.gameObject.SetActive(false);
        mailTxt2.gameObject.SetActive(false);
        mailTxt3.gameObject.SetActive(false);
        mailTxt1.gameObject.SetActive(false);
    }

    public void Click()
    {
        // Has the user already clicked?
        if (_AlreadyClicked)
        {
            // Yes
            _AlreadyClicked = false;

            // Show object
            start.gameObject.SetActive(false);
            startIcon.gameObject.SetActive(false);
        }
        else
        {
            // No -- first click
            _AlreadyClicked = true;

            // Hide object
            start.gameObject.SetActive(true);
            startIcon.gameObject.SetActive(true);
        }
    }


    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
