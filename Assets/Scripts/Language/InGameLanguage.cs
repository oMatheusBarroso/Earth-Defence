using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InGameLanguage : MonoBehaviour
{
    public Text PauseMenuTittleText;
    public Text ResumeButtonText;
    public Text OptionsButtonText;
    public Text QuitButtonText;

    public Text BackButtonText;

    public Text QuestionText;
    public Text YesButtonText;
    public Text NoButtonText;

    private void Start()
    {
        OptionsMenu.Language = PlayerPrefs.GetString("language");
    }

    void Update()
    {
        if (OptionsMenu.Language == "PT-BR")
        {
            PauseMenuTittleText.text = "Pausa";
            ResumeButtonText.text = "Continuar";
            OptionsButtonText.text = "Opções";
            QuitButtonText.text = "Sair";

            BackButtonText.text = "Voltar";

            QuestionText.text = "Você tem certeza que quer sair? Perderá todo o progresso se sair agora";
            YesButtonText.text = "Sim";
            NoButtonText.text = "Não";
        }
        else if (OptionsMenu.Language == "EN")
        {
            PauseMenuTittleText.text = "Pause";
            ResumeButtonText.text = "Resume";
            OptionsButtonText.text = "Options";
            QuitButtonText.text = "Quit";

            BackButtonText.text = "Back";

            QuestionText.text = "Are you sure you want to leave? You will lose all progress if you leave now";
            YesButtonText.text = "Yes";
            NoButtonText.text = "No";
        }
    }
}
