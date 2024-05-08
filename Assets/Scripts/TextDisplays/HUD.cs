using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public GameObject HealthPercentageUI;
    public GameObject CounterStoppedAsteroidsUI;
    public GameObject CounterUnstoppedAsteroidsUI;
    public GameObject TimerUI;
    public GameObject GameOverUI;

    public Text HealthPercentageText;
    public Text CounterStoppedAsteroidsText;
    public Text CounterUnstoppedAsteroidsText;

    public Text MinText;
    public Text Points01;
    public Text SecText;
    public Text Points02;
    public Text DecText;

    private void Start()
    {
        OptionsMenu.ToggleGameIntro = Convert.ToBoolean(PlayerPrefs.GetString("intro", "true"));
        OptionsMenu.ToggleHealthPercentage = Convert.ToBoolean(PlayerPrefs.GetString("healthP", "true"));
        OptionsMenu.ToggleCounterStoppedAsteroids = Convert.ToBoolean(PlayerPrefs.GetString("asteroidsS", "true"));
        OptionsMenu.ToggleCounterUnstoppedAsteroids = Convert.ToBoolean(PlayerPrefs.GetString("asteroidsU", "true"));
        OptionsMenu.ToggleTimer = Convert.ToBoolean(PlayerPrefs.GetString("timer", "true"));
    }

    void Update()
    {
        if (OptionsMenu.ToggleHealthPercentage == true)
        {
            HealthPercentageUI.SetActive(true);
        }

        if (OptionsMenu.ToggleCounterStoppedAsteroids == true)
        {
            CounterStoppedAsteroidsUI.SetActive(true);
        }

        if (OptionsMenu.ToggleCounterUnstoppedAsteroids == true)
        {
            CounterUnstoppedAsteroidsUI.SetActive(true);
        }

        if (OptionsMenu.ToggleTimer == true)
        {
            TimerUI.SetActive(true);
        }

        //Health Percentage option
        if (PlayerLifeSystem.HealthPercentage > 0)
        {
            HealthPercentageText.text = "" + PlayerLifeSystem.HealthPercentage + "%";
        }
        else
        {
            HealthPercentageText.text = "0%";
        }
        
        //Stopped Asteroids option

        if (Counters.totalStoppedAsteroids < 10)
        {
            CounterStoppedAsteroidsText.text = "0" + Counters.totalStoppedAsteroids;
        }
        else
        {
            CounterStoppedAsteroidsText.text = "" +Counters.totalStoppedAsteroids;
        }

        //Unstopped Asteroids option
        if (Counters.totalUnstoppedAsteroids < 10)
        {
            CounterUnstoppedAsteroidsText.text = "0" + Counters.totalUnstoppedAsteroids;
        }
        else
        {
            CounterUnstoppedAsteroidsText.text = "" + Counters.totalUnstoppedAsteroids;
        }

        //Game Over
        if (Menu.gameOver == true)
        {
            MinText.color = Points01.color = SecText.color = 
                Points02.color = DecText.color = Color.red; //muda a cor do timer para vermelho ao fim do jogo
            GameOverUI.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
