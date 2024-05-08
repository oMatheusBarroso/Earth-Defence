using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsMenu : MonoBehaviour
{
    //Controle de dificuldade
    //public static int Difficulty = 1; // 0 - Easy, 1 - Normal, 2 - Hard, 3 - Hell
    //public Dropdown difficultyDropdown;

    //Controle de idioma
    public static string Language; // PT-BR, EN
    public int languageNum;
    public Dropdown languageDropdown;

    //Controle de região
    public static string Region = "none"; //Asia-Oceania, Africa-EU-MiddleEast, SA, CA-NA
    
    //Seleção de música
    public static int inGameMusic;
    public Dropdown songsDropdown;

    //Toggles
    public static bool ToggleGameIntro;
    public static bool ToggleHealthPercentage;
    public static bool ToggleCounterStoppedAsteroids;
    public static bool ToggleCounterUnstoppedAsteroids;
    public static bool ToggleTimer;
    
    //Sistema de cor dos toggles
    public GameObject OnColorIntro;
    public GameObject OffColorIntro;

    public GameObject OnColorHealthPercentage;
    public GameObject OffColorHealthPercentage;

    public GameObject OnColorStopped;
    public GameObject OffColorStopped;

    public GameObject OnColorUnstopped;
    public GameObject OffColorUnstopped;

    public GameObject OnColorTimer;
    public GameObject OffColorTimer;

    public GameObject Page01UI;
    public GameObject Page02UI;
    public GameObject Page03UI;

    //Volume Control
    public AudioMixer mainMixer;
    public AudioMixer musicMixer;

    //Resolution Control
    Resolution[] resolutions;
    public Dropdown resolutionsDropdown;

    private void Start()
    {
        ToggleGameIntro = Convert.ToBoolean(PlayerPrefs.GetString("intro", "true"));
        ToggleHealthPercentage = Convert.ToBoolean(PlayerPrefs.GetString("healthP", "true"));
        ToggleCounterStoppedAsteroids = Convert.ToBoolean(PlayerPrefs.GetString("asteroidsS", "true"));
        ToggleCounterUnstoppedAsteroids = Convert.ToBoolean(PlayerPrefs.GetString("asteroidsU", "true"));
        ToggleTimer = Convert.ToBoolean(PlayerPrefs.GetString("timer", "true"));

        Language = PlayerPrefs.GetString("language", "PT-BR");

        //Difficulty = Convert.ToInt32(PlayerPrefs.GetString("difficulty"));

        Region = PlayerPrefs.GetString("region");

        inGameMusic = PlayerPrefs.GetInt("Current Music", 0);

        //Lista de resoluções
        //resolutions = Screen.resolutions; //Pega a informação de quais opções de resolução estão disponíveis
        //resolutionsDropdown.ClearOptions(); //Limpa a lista de resoluções
        //List<string> options = new List<string>(); //Cria uma lista de strings para as opções de resolução
        //
        //int currentResolutionIndex = 0;
        //
        //for (int i = 0; i < resolutions.Length; i++) //funciona como uma "conversão" para string
        //{
        //    string option = resolutions[i].width + "X" + resolutions[i].height;
        //    options.Add(option);
        //
        //    if(resolutions[i].width == Screen.currentResolution.width && 
        //        resolutions[i].height == Screen.currentResolution.height)
        //    {
        //        currentResolutionIndex = i;
        //    }
        //}
        //
        //resolutionsDropdown.AddOptions(options); //adiciona as opções da lista para o dropdown
        //resolutionsDropdown.value = currentResolutionIndex;
        //resolutionsDropdown.RefreshShownValue();

        //Controle de dificuldade
        //difficultyDropdown.value = Difficulty;

        //Controle de idioma
        if (Language == "PT-BR")
        {
            languageNum = 0;
        }
        else if (Language == "EN")
        {
            languageNum = 1;
        }

        languageDropdown.value = languageNum;

        //Seleção de música
        songsDropdown.value = inGameMusic;
    }

    private void Update()
    {
        //Intro color
        if (ToggleGameIntro == true)
        {
            OnColorIntro.SetActive(true);
            OffColorIntro.SetActive(false);
        }
        else
        {
            OffColorIntro.SetActive(true);
            OnColorIntro.SetActive(false);
        }

        //Health Percentage color
        if (ToggleHealthPercentage == true)
        {
            OnColorHealthPercentage.SetActive(true);
            OffColorHealthPercentage.SetActive(false);
        }
        else
        {
            OffColorHealthPercentage.SetActive(true);
            OnColorHealthPercentage.SetActive(false);
        }

        //Stopped Asteroids color
        if (ToggleCounterStoppedAsteroids == true)
        {
            OnColorStopped.SetActive(true);
            OffColorStopped.SetActive(false);
        }
        else
        {
            OffColorStopped.SetActive(true);
            OnColorStopped.SetActive(false);
        }

        //Unstopped Asteroids color
        if (ToggleCounterUnstoppedAsteroids == true)
        {
            OnColorUnstopped.SetActive(true);
            OffColorUnstopped.SetActive(false);
        }
        else
        {
            OffColorUnstopped.SetActive(true);
            OnColorUnstopped.SetActive(false);
        }

        //Timer color
        if (ToggleTimer == true)
        {
            OnColorTimer.SetActive(true);
            OffColorTimer.SetActive(false);
        }
        else
        {
            OffColorTimer.SetActive(true);
            OnColorTimer.SetActive(false);
        }
    }

    //Métodos da primeira página de opções

    public void GoToPage2()
    {
        Page01UI.SetActive(false);
        Page02UI.SetActive(true);
    }

    public void SetResolution(int R)
    {
        //Resolution resolution = resolutions[R];
        //Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);

        if(R == 1)
        {
            Screen.SetResolution(1920, 1080, Screen.fullScreen);
        }
        else if (R == 2)
        {
            Screen.SetResolution(1280, 720, Screen.fullScreen);
        }
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }

    public void SetQuality(int Q)
    {
        QualitySettings.SetQualityLevel(Q);
    }

    public void SetMainVolume(float volume)
    {
        mainMixer.SetFloat("Main Volume", volume);
    }

    public void SetMusicVolume(float volumeM)
    {
        musicMixer.SetFloat("Music Volume", volumeM);
    }

    //public void SetDifficulty(int D)
    //{
    //    Difficulty = D;
    //    Debug.Log("Difficulty: " + D);
    //}

    public void SetLanguage(int L)
    {
        if (L == 0)
        {
            Language = "PT-BR";
            languageNum = 0;
        }
        else if(L == 1)
        {
            Language = "EN";
            languageNum = 1;
        }

        Debug.Log("Linguagem: " + L + " " + Language);
    }

    public void SetMusic (int M)
    {
        inGameMusic = M;
        Debug.Log("Music: " + M);
    }

    //Métodos da segunda página de opções

    public void BackToPage1()
    {
        Page03UI.SetActive(false);
        Page02UI.SetActive(false);
        Page01UI.SetActive(true);
    }

    public void GoToPage3()
    {
        Page01UI.SetActive(false);
        Page02UI.SetActive(false);
        Page03UI.SetActive(true);
    }

    public void ToggleIntroOn()
    {
        ToggleGameIntro = true;
        Debug.Log("Intro: " +ToggleGameIntro);
    }

    public void ToggleIntroOff()
    {
        ToggleGameIntro = false;
        Debug.Log("Intro: " + ToggleGameIntro);
    }

    public void ToggleHealthPercentageOn()
    {
        ToggleHealthPercentage = true;
        Debug.Log("Health Percentage: " + ToggleHealthPercentage);
    }

    public void ToggleHealthPercentageOff()
    {
        ToggleHealthPercentage = false;
        Debug.Log("Health Percentage: " + ToggleHealthPercentage);
    }

    public void ToggleCounterStoppedAsteroidsOn()
    {
        ToggleCounterStoppedAsteroids = true;
        Debug.Log("Counter Stopped Asteroids: " + ToggleCounterStoppedAsteroids);
    }

    public void ToggleCounterStoppedAsteroidsOff()
    {
        ToggleCounterStoppedAsteroids = false;
        Debug.Log("Counter Stopped Asteroids: " + ToggleCounterStoppedAsteroids);
    }

    public void ToggleCounterUnstoppedAsteroidsOn()
    {
        ToggleCounterUnstoppedAsteroids = true;

        Debug.Log("Counter Unstopped Asteroids: " + ToggleCounterUnstoppedAsteroids);
    }

    public void ToggleCounterUnstoppedAsteroidsOff()
    {
        ToggleCounterUnstoppedAsteroids = false;

        Debug.Log("Counter Unstopped Asteroids: " + ToggleCounterUnstoppedAsteroids);
    }

    public void ToggleTimerOn()
    {
        ToggleTimer = true;

        Debug.Log("Timer: " + ToggleTimer);
    }

    public void ToggleTimerOff()
    {
        ToggleTimer = false;

        Debug.Log("Timer: " + ToggleTimer);
    }

    //Métodos da terceira página de opções (menu de personalização)

    public void BackToPage2()
    {
        Page03UI.SetActive(false);
        Page02UI.SetActive(true);
    }

    public void AsiaOceaniaSelected()
    {
        OptionsMenu.Region = "Asia-Oceania";
        PlayerPrefs.SetString("region", OptionsMenu.Region);
    }

    public void AfricaEuropeMiddleEastSelected()
    {
        OptionsMenu.Region = "Africa-EU-MiddleEast";
        PlayerPrefs.SetString("region", OptionsMenu.Region);
    }

    public void SouthAmericaSelected()
    {
        OptionsMenu.Region = "SA";
        PlayerPrefs.SetString("region", OptionsMenu.Region);
    }

    public void CentralNorthAmericasSelected()
    {
        OptionsMenu.Region = "CA-NA";
        PlayerPrefs.SetString("region", OptionsMenu.Region);
    }

    //Métodos gerais

    public void BackToMainMenu()
    {
        SceneManager.LoadScene("3.0-Main Menu");
    }

    public void SeeStatus()
    {
        SceneManager.LoadScene("4.0-Status");
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("intro", "" + ToggleGameIntro);
        PlayerPrefs.SetString("healtP", "" + ToggleHealthPercentage);
        PlayerPrefs.SetString("asteroidsS", "" + ToggleCounterStoppedAsteroids);
        PlayerPrefs.SetString("asteroidsU", "" + ToggleCounterUnstoppedAsteroids);
        PlayerPrefs.SetString("timer", "" + ToggleTimer);

        PlayerPrefs.SetString("language", Language);

        //PlayerPrefs.GetString("difficulty", "" + Difficulty);

        PlayerPrefs.SetString("region", Region);


        PlayerPrefs.SetInt("Current Music", + inGameMusic);
    }
}
