using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIScript : MonoBehaviour
{
    
    public GameObject Object;
    public GameObject MusicToggleButton;
    public GameObject SoundToggleButton;
    private BombController bombController;
    [SerializeField] GameObject Home, SettingsUI;
    public AudioSource audioSource1, audioSource2, audioSource3;



    void Start()
    {
        bombController = Object.GetComponent<BombController>(); 
        bombController.straightSpeed = 0;
        bombController.horizontalSpeed = 0;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void SettingsButton()
    {
        Home.SetActive(false);
        SettingsUI.SetActive(true);
    }

    public void SoundToggle()
    {
        if (SoundToggleButton.GetComponent<Toggle>().isOn == true)
        {
            audioSource1.GetComponent<AudioSource>().mute = true;
            audioSource2.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            audioSource1.GetComponent<AudioSource>().mute = false;
            audioSource2.GetComponent<AudioSource>().mute = false;
        }
    }

    public void MusicToggle()
    {
        if (MusicToggleButton.GetComponent<Toggle>().isOn == true)
        {
            //audioSource3.enabled = false;
            audioSource3.GetComponent<AudioSource>().mute = true;
        }
        else
        {
            //audioSource3.enabled = true;
            audioSource3.GetComponent<AudioSource>().mute = false;
        }
    }

    public void CloseButton()
    {
        SettingsUI.SetActive(false);
        Home.SetActive(true);
    }
}
