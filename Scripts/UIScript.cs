using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Object;
    public GameObject musicImage;
    public GameObject soundImage;
    private BombController bombController;
    [SerializeField] GameObject GameUI, Home, SettingsUI, PauseMenu;


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

    public void StartButton()
    {
        Home.SetActive(false);
        GameUI.SetActive(true);
        bombController.straightSpeed = 6.0f;
        bombController.horizontalSpeed = 3.0f;
    }

    public void SettingsButton()
    {
        Home.SetActive(false);
        SettingsUI.SetActive(true);
    }

    public void SoundButton(bool muted)
    {
        if(muted){
            soundImage.SetActive(false);
        }
        else
        {
            soundImage.SetActive(true);
        }
    }

    public void PauseButton()
    {
        GameUI.SetActive(false);
        bombController.straightSpeed = 0.0f;
        bombController.horizontalSpeed = 0.0f;
        PauseMenu.SetActive(true);
    }

    public void ContinueButton()
    {
        PauseMenu.SetActive(false);
        bombController.straightSpeed = 6.0f;
        bombController.horizontalSpeed = 3.0f;
        GameUI.SetActive(true);
    }

    public void RestartButton()
    {
        PauseMenu.SetActive(false);
        SceneManager.LoadScene("SampleScene");
        
    }

    public void CloseButton()
    {
        SettingsUI.SetActive(false);
        Home.SetActive(true);
    }
}
