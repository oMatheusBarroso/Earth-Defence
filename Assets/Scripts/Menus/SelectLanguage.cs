using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SelectLanguage : MonoBehaviour
{
    public GameObject LanguageSelectionUI;
    public GameObject RegionSelectionUI;

    private void Start()
    {
        OptionsMenu.Language = PlayerPrefs.GetString("language", "none");
    }

    public void PortugueseSelected()
    {
        OptionsMenu.Language = "PT-BR";
        LanguageSelectionUI.SetActive(false);
        RegionSelectionUI.SetActive(true);
        //SceneManager.LoadScene("2.0-Initial CutScene");

        Debug.Log("Português do Brasil selecionado; " + "OptionsMenu.Language: " + OptionsMenu.Language);
    }

    public void EnglishSelected()
    {
        OptionsMenu.Language = "EN";
        LanguageSelectionUI.SetActive(false);
        RegionSelectionUI.SetActive(true);
        //SceneManager.LoadScene("2.0-Initial CutScene");

        Debug.Log("English selected; " + "OptionsMenu.Language: " + OptionsMenu.Language);
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("language", OptionsMenu.Language);
        Debug.Log("Informação de linguagem conservada e passada adiante.");
    }
}
