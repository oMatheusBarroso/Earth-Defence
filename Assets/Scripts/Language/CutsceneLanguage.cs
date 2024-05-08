using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutsceneLanguage : MonoBehaviour
{
    public Text PlayButtonText;
    public Text OptionsButtonText;
    public Text CreditsButtonText;
    public Text QuitButtonText;

    public Text Text01;
    public Text Text02;
    public Text Text03;
    public Text Text04;
    public Text Text05;
    public Text Text06;
    public Text Text07;
    
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

            Text01.text = "Em uma galáxia muito, muito distante...";
            Text02.text = "Um sistema solar colapsou...";
            Text03.text = "Destruindo todos os seus planetas";
            Text04.text = "Mas...";
            Text05.text = "Ameaçando a Terra com seus destroços";
            Text06.text = "Ainda há esperança!";
            Text07.text = "O Escudo " +
                "de Cinádio";
        }
        else if (OptionsMenu.Language == "EN")
        {
            PlayButtonText.text = "Play";
            OptionsButtonText.text = "Options";
            CreditsButtonText.text = "Credits";
            QuitButtonText.text = "Quit";

            Text01.text = "In a galaxy far far away...";
            Text02.text = "A solar system colapsed...";
            Text03.text = "Destroying all of its planets";
            Text04.text = "But...";
            Text05.text = "Threatening the Earth with its wreckage";
            Text06.text = "There is still hope!";
            Text07.text = "The Cinadium " +
                "Shield";
        }
    }
}
