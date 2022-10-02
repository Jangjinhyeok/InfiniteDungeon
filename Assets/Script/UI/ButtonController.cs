using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonController : MonoBehaviour
{

    public GameObject MenuPanel;
    public GameObject SettingPanel;
    public Text QualityHigh;
    public Text QualityMiddle;
    public Text QualityLow;
    Color newColor;
    string ColorCodeYellow;
    string ColorCodeWhite;
    //AudioSource audioSource;
    //public AudioClip audioClick;
    void Start()
    {
        ColorCodeYellow = "#FFD58C";
        ColorCodeWhite = "#FFFFFF";
        //this.audioSource = GetComponent<AudioSource>();
        if (Time.timeScale == 0)
            Time.timeScale = 1;
    }
    public void LoadMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void Menu_button()
    {
        Time.timeScale = 0; //게임 일시정지
        MenuPanel.SetActive(true);
    }

    public void Continue()
    {
        Time.timeScale = 1;
        MenuPanel.SetActive(false);
    }
    public void Setting_button()
    {
        SettingPanel.SetActive(true);
        MenuPanel.SetActive(false);
    }
    public void Ok_button()
    {
        SettingPanel.SetActive(false);
        MenuPanel.SetActive(true);
    }

    public void GameExit()
    {
        Application.Quit();
    }
    public void LoadTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void click_sound()
    {
        //audioSource.clip = audioClick;
        //audioSource.Play();
    }
    public void Quality_High()
    {
        if (ColorUtility.TryParseHtmlString(ColorCodeYellow, out newColor))
        {
            QualityHigh.color = newColor;
        }
        if (ColorUtility.TryParseHtmlString(ColorCodeWhite, out newColor))
        {
            QualityMiddle.color = newColor;
        }
        if (ColorUtility.TryParseHtmlString(ColorCodeWhite, out newColor))
        {
            QualityLow.color = newColor;
        }
        QualitySettings.SetQualityLevel(5, true);
    }
    public void Quality_Middle()
    {
        if (ColorUtility.TryParseHtmlString(ColorCodeYellow, out newColor))
        {
            QualityMiddle.color = newColor;
        }
        if (ColorUtility.TryParseHtmlString(ColorCodeWhite, out newColor))
        {
            QualityHigh.color = newColor;
        }
        if (ColorUtility.TryParseHtmlString(ColorCodeWhite, out newColor))
        {
            QualityLow.color = newColor;
        }
        QualitySettings.SetQualityLevel(3, true);
    }
    public void Quality_Low()
    {
        if (ColorUtility.TryParseHtmlString(ColorCodeYellow, out newColor))
        {
            QualityLow.color = newColor;
        }
        if (ColorUtility.TryParseHtmlString(ColorCodeWhite, out newColor))
        {
            QualityMiddle.color = newColor;
        }
        if (ColorUtility.TryParseHtmlString(ColorCodeWhite, out newColor))
        {
            QualityHigh.color = newColor;
        }
        QualitySettings.SetQualityLevel(0, true);
    }
}

