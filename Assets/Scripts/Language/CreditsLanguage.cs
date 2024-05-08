using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsLanguage : MonoBehaviour
{
    public Text CreditsTitleText;
    public Text BackButtonText;

    void Start()
    {
        OptionsMenu.Language = PlayerPrefs.GetString("language");
    }

    void Update()
    {
        if (OptionsMenu.Language == "PT-BR")
        {
            CreditsTitleText.text = "Créditos";
            BackButtonText.text = "Voltar";
        }
        else if (OptionsMenu.Language == "EN")
        {
            CreditsTitleText.text = "Credits";
            BackButtonText.text = "Back";
        }
    }
}
