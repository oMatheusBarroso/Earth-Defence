using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsMenuLanguage : MonoBehaviour
{
    public Text OptionsTitleText;

    //Textos página 01

    public Text FullScreenText;
    public Text GraphicsText;
    public Text SoundVolumeText;
    public Text MusicVolumeText;
    public Text SongSelectionText;
    public Text DifficultySelectionText;
    public Text LanguageSelectionText;

    public Text ToggleIntroText;
    public Text ToggleHealthPercentageText;
    public Text ToggleCounterStoppedAsteroids;
    public Text ToggleCounterUnstoppedAsteroids;
    public Text ToggleTimerText;

    public Text AsiaOceaniaText;
    public Text AfricaEuropeMiddleEastText;
    public Text SouthAmericaText;
    public Text CentralNorthAmericaText;

    //Textos Gerais

    public Text NextButton01Text;
    public Text NextButton02Text;

    public Text LastButton01Text;
    public Text LastButton02Text;

    public Text BackButtonText;

    private void Start()
    {
        OptionsMenu.Language = PlayerPrefs.GetString("language");
    }

    void Update()
    {
        if (OptionsMenu.Language == "PT-BR")
        {
            OptionsTitleText.text = "Opções";

            FullScreenText.text = "Tela cheia";
            GraphicsText.text = "Gráficos";
            SoundVolumeText.text = "Volume do Som:";
            MusicVolumeText.text = "Volume da Música:";
            SongSelectionText.text = "Escolha qual música quer ouvir jogando";
            DifficultySelectionText.text = "Dificuldade:";
            LanguageSelectionText.text = "Linguagem:";

            ToggleIntroText.text = "Introdução ao iniciar o jogo";
            ToggleHealthPercentageText.text = "Barra de vida com porcentagem";
            ToggleCounterStoppedAsteroids.text = "Contador de asteroides interceptados";
            ToggleCounterUnstoppedAsteroids.text = "Contador de asteroides perdidos";
            ToggleTimerText.text = "Cronômetro";

            AsiaOceaniaText.text = "Ásia ou Oceania";
            AfricaEuropeMiddleEastText.text = "África, Europa ou Oriente Médio";
            SouthAmericaText.text = "América do Sul";
            CentralNorthAmericaText.text = "América Central ou do Norte";

            NextButton01Text.text = NextButton02Text.text = "Próximo";

            LastButton01Text.text = LastButton02Text.text = "Anterior";

            BackButtonText.text = "Voltar";
}
        else if (OptionsMenu.Language == "EN")
        {
            OptionsTitleText.text = "Options";

            FullScreenText.text = "Fullscreen";
            GraphicsText.text = "Graphics";
            SoundVolumeText.text = "Sound Volume:";
            MusicVolumeText.text = "Music Volume:";
            SongSelectionText.text = "Select the song you want to hear in game:";
            DifficultySelectionText.text = "Difficulty:";
            LanguageSelectionText.text = "Language:";

            ToggleIntroText.text = "Intro when game starts";
            ToggleHealthPercentageText.text = "Healthbar with percentage";
            ToggleCounterStoppedAsteroids.text = "Counter for stopped asteroids";
            ToggleCounterUnstoppedAsteroids.text = "Counter for unstopped asteroids";
            ToggleTimerText.text = "Timer";

            AsiaOceaniaText.text = "Asia or Oceania";
            AfricaEuropeMiddleEastText.text = "Africa, Europe or Middle East";
            SouthAmericaText.text = "South America";
            CentralNorthAmericaText.text = "Central or North America";

            NextButton01Text.text = NextButton02Text.text = "Next";

            LastButton01Text.text = LastButton02Text.text = "Previous";

            BackButtonText.text = "Back";
        }
    }
}
