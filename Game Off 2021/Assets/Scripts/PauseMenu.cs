using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject menuPanel;
    public Slider volumeSlider;

    public float startVolume = 1f;
    public float currentVolume;

    string newVolume = "VOLUME_SLIDER"; //Can change to whatever you want as long as it is not null or empty


    void Start()
    {
        //Load volume from prevois saved state. If it does not exist, use 1 as default
        volumeSlider.value = PlayerPrefs.GetFloat(newVolume, 1);
        currentVolume = volumeSlider.value;
    }

    void UpdateVolume(float _volume)
    {
        currentVolume = _volume;

        PlayerPrefs.SetFloat(newVolume, _volume);
        PlayerPrefs.Save();
    }
    void OnEnable()
    {
        //Register Slider Events
        volumeSlider.onValueChanged.AddListener(delegate { sliderCallBack(volumeSlider); });
    }


    private void sliderCallBack(Slider sliderMoved)
    {
        //Volume Slider Moved
        if (sliderMoved == volumeSlider)
        {
            UpdateVolume(sliderMoved.value);
        }
    }
    void OnDisable()
    {
        //Un-Register Slider Events
        volumeSlider.onValueChanged.RemoveAllListeners();
    }





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
