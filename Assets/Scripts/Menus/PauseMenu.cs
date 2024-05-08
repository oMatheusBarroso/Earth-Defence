using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused;
    private static bool optionOpened = false;

    public GameObject pauseMenuUI;
    public GameObject optionsMenuUI;
    public GameObject questionMenuUI;
    //public GameObject gameOverUI;

    public GameObject CounterStoppedAsteroidsUI;
    public GameObject CounterUnstoppedAsteroidsUI;
    public GameObject TimerUI;

    //TIMER
    public Text MinText;
    public Text Points01;
    public Text SecText;
    public Text Points02;
    public Text DecText;
    public Color originalTimerColor;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) || Input.GetKeyDown(KeyCode.Space))
        {
            if (optionOpened == false)
            {
                if (gamePaused)
                {
                    Resume();
                }
                else
                {
                    Pause();
                }
            }
        }
    }

    public void Resume()
    {
        MinText.color = Points01.color = SecText.color = 
            Points02.color = DecText.color = originalTimerColor; //muda a cor do timer de volta para o normal ao reotrnar ao jogo
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    void Pause()
    {
        MinText.color = Points01.color = SecText.color = 
            Points02.color = DecText.color = Color.yellow; //muda a cor do timer para amarelo ao pausar
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        gamePaused = true;
    }

    public void BackToMainMenu()
    {
        pauseMenuUI.SetActive(false);
        questionMenuUI.SetActive(true);
    }

    public void OpenOptions()
    {
        optionOpened = true;
        pauseMenuUI.SetActive(false);
        optionsMenuUI.SetActive(true);
    }

    public void BackToPauseMenu() //função do botão "voltar" do menu de opções in-game
    {
        optionOpened = false;
        Time.timeScale = 0f;
        questionMenuUI.SetActive(false);
        optionsMenuUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void LoadMainMenu()
    {
        ResetGameValues();
        Time.timeScale = 1f;
        //gameOverUI.SetActive(false);
        SceneManager.LoadScene("3.0-Main Menu");
    }

    public void ResetGameValues()
    {
        PlayerLifeSystem.currentEarthLife = 500f;
        Counters.totalStoppedAsteroids = 0;
        Counters.totalUnstoppedAsteroids = 0;
    }

    public void Quit()
    {
        //Reatribuir valores originais à vida e contadores
        Time.timeScale = 1f;
        SceneManager.LoadScene("6.0-Quit");
        ResetGameValues();
    }
}
