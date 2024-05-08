using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectRegion : MonoBehaviour
{
    private void Start()
    {
        OptionsMenu.Region = PlayerPrefs.GetString("region", "none");
    }

   public void RegionSelected()
    {
        SceneManager.LoadScene("2.0-Initial CutScene");
    }

    public void AsiaOceaniaSelected()
    {
        OptionsMenu.Region = "Asia-Oceania";
    }

    public void AfricaEuropeMiddleEastSelected()
    {
        OptionsMenu.Region = "Africa-EU-MiddleEast";
    }

    public void SouthAmericaSelected()
    {
        OptionsMenu.Region = "SA";
    }

    public void CentralNorthAmericasSelected()
    {
        OptionsMenu.Region = "CA-NA";
    }

    private void OnDestroy()
    {
        PlayerPrefs.SetString("region", OptionsMenu.Region);
        Debug.Log("Region Selected: " + "OptionsMenu.Region =" + OptionsMenu.Region);
    }
}
