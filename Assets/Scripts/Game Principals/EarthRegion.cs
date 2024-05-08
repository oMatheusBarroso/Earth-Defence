using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthRegion : MonoBehaviour
{
    public Sprite SouthAmerica;
    public Sprite CentralAndNorthAmerica;
    public Sprite AsiaOceania;
    public Sprite AfricaEuropeMiddleEast;

    SpriteRenderer EarthSprite;

    //public SpriteRenderer EarthSprite;

    private void Start()
    {
        OptionsMenu.Region = PlayerPrefs.GetString("region", "none");

        EarthSprite = this.GetComponent<SpriteRenderer>();

        if (OptionsMenu.Region == "Asia-Oceania")
        {
            EarthSprite.sprite = AsiaOceania;
        }
        else if (OptionsMenu.Region == "Africa-EU-MiddleEast")
        {
            EarthSprite.sprite = AfricaEuropeMiddleEast;
        }
        else if (OptionsMenu.Region == "SA")
        {
            EarthSprite.sprite = SouthAmerica;
        }
        else if (OptionsMenu.Region == "CA-NA")
        {
            EarthSprite.sprite = CentralAndNorthAmerica;
        }
    }

    private void Update()
    {
        if (OptionsMenu.Region == "Asia-Oceania")
        {
            EarthSprite.sprite = AsiaOceania;
        }
        else if (OptionsMenu.Region == "Africa-EU-MiddleEast")
        {
            EarthSprite.sprite = AfricaEuropeMiddleEast;
        }
        else if (OptionsMenu.Region == "SA")
        {
            EarthSprite.sprite = SouthAmerica;
        }
        else if (OptionsMenu.Region == "CA-NA")
        {
            EarthSprite.sprite = CentralAndNorthAmerica;
        }
    }
}
