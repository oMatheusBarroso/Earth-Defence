using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuLanguage : MonoBehaviour
{
    public Text PlayButtonText;
    public Text OptionsButtonText;
    public Text CreditsButtonText;
    public Text QuitButtonText;

    //public Text EasyButtonText;
    //public Text HardButtonText;
    //public Text HellButtonText;

    private void Start()
    {
        OptionsMenu.Language = PlayerPrefs.GetString("language");
    }

    void Update()
    {
        if (OptionsMenu.Language == "PT-BR")
        {
            PlayButtonText.text = "Jogar";
            OptionsButtonText.text = "Opções";
            CreditsButtonText.text = "Créditos";
            QuitButtonText.text = "Sair";

            //EasyButtonText.text = "Fácil";
            //HardButtonText.text = "Difícil";
            //HellButtonText.text = "Infernal";
        }
        else if (OptionsMenu.Language == "EN")
        {
            PlayButtonText.text = "Play";
            OptionsButtonText.text = "Options";
            CreditsButtonText.text = "Credits";
            QuitButtonText.text = "Quit";

            //EasyButtonText.text = "Easy";
            //HardButtonText.text = "Hard";
            //HellButtonText.text = "Hell";
        }
    }
}
