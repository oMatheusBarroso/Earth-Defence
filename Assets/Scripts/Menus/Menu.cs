using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    public static bool gameStarted = true; //usado no script dos spawners
    public static bool gameOver = false;

    public GameObject MainMenuUI;
    //public GameObject DifficultySelectionUI;

    //private void Start()
    //{
    //    OptionsMenu.Difficulty = Convert.ToInt32(PlayerPrefs.GetString("difficulty"));
    //}

    public void SelectDifficulty()
    {
        PlayerLifeSystem.currentEarthLife = 500f;

        SceneManager.LoadScene("3.1-Game Scene");

        //if(OptionsMenu.Difficulty <= 4)
        //{
        //    MainMenuUI.SetActive(false);
        //    DifficultySelectionUI.SetActive(true);
        //}
        //else
        //{
        //    SceneManager.LoadScene("3.1-Game Scene");
        //}
    }

    //public void StartGameEasy()
    //{
    //    OptionsMenu.Difficulty = 0;
    //    SceneManager.LoadScene("3.1-Game Scene");
    //
    //    Debug.Log("Easy Mode selected; " + "OptionsMenu.Difficulty: " + OptionsMenu.Difficulty);
    //}
    //
    //public void StartGameNormal()
    //{
    //    OptionsMenu.Difficulty = 1;
    //    SceneManager.LoadScene("3.1-Game Scene");
    //    Debug.Log("Normal Mode selected; " + "OptionsMenu.Difficulty: " + OptionsMenu.Difficulty);
    //}
    //
    //public void StartGameHard()
    //{
    //    OptionsMenu.Difficulty = 2;
    //    SceneManager.LoadScene("3.1-Game Scene");
    //    Debug.Log("Hard Mode selected; " + "OptionsMenu.Difficulty: " + OptionsMenu.Difficulty);
    //}
    //
    //public void StartGameHell()
    //{
    //    OptionsMenu.Difficulty = 3;
    //    SceneManager.LoadScene("3.1-Game Scene");
    //    Debug.Log("Hell Mode selected; " + "OptionsMenu.Difficulty: " + OptionsMenu.Difficulty);
    //}

    public void OpenOptionsMenu()
    {
        SceneManager.LoadScene("3.2-Options Menu");
    }

    public void ShowCredits()
    {
        SceneManager.LoadScene("3.3-Credits");
    }

    public void Quit()
    {
        SceneManager.LoadScene("6.0-Quit");
    }

    //public void OnDestroy()
    //{
    //    PlayerPrefs.GetString("difficulty", "" + OptionsMenu.Difficulty);
    //}
}
