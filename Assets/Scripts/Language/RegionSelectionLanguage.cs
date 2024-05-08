using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegionSelectionLanguage : MonoBehaviour
{
    public Text TitleText;
    public Text SubtitleText;
    public Text AsiaOceaniaText;
    public Text AfricaEuropeMiddleEastText;
    public Text SouthAmericaText;
    public Text CentralNorthAmericasText;

    void Start()
    {
        OptionsMenu.Language = PlayerPrefs.GetString("language");
    }

    void Update()
    {
        if (OptionsMenu.Language == "PT-BR")
        {
            TitleText.text = "Selecione sua região";
            SubtitleText.text = "Muda apenas visuais do jogo";
            AsiaOceaniaText.text = "Ásia ou Oceania";
            AfricaEuropeMiddleEastText.text = "África, Europa ou Oriente Médio";
            SouthAmericaText.text = "América do Sul";
            CentralNorthAmericasText.text = "América Central ou do Norte";
        }
        else if(OptionsMenu.Language == "EN")
        {
            TitleText.text = "Select your region";
            SubtitleText.text = "Changes only game visuals";
            AsiaOceaniaText.text = "Asia or Oceania";
            AfricaEuropeMiddleEastText.text = "Africa, Europe or Middle East";
            SouthAmericaText.text = "South America";
            CentralNorthAmericasText.text = "Central or North America";
        }
    }
}
