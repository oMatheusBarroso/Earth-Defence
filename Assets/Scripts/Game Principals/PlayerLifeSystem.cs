using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerLifeSystem : MonoBehaviour
{
    private static float baseEarthLife = 500f; //era double
    private static float modifiers = 1;
    // SOMAR na variável todos os modificadores que aumentam a vida do jogador; ex.: modificador que adiciona 50% de vida soma 0,5f à variável
    public static float EarthLife = baseEarthLife * modifiers; //era double
    public static float currentEarthLife;

    public static float HealthPercentage;

    private void Start()
    {
        currentEarthLife = 500f;
        HealthPercentage = 100;
    }

    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("smallAsteroid"))
        {
            currentEarthLife -= Asteroid.smallAsteroidDamage;
        }
        else if (collision.gameObject.tag.Equals("mediumAsteroid"))
        {
            currentEarthLife -= Asteroid.mediumAsteroidDamage;
        }
        else if (collision.gameObject.tag.Equals("bigAsteroid"))
        {
            currentEarthLife -= Asteroid.bigAsteroidDamage;
        }

        Counters.totalUnstoppedAsteroids += 1;

        //diminuição da barra de vida ao levar dano
        HealthBar.sizeNormalized = currentEarthLife / EarthLife; //sizeNormalized é a porcentagem da vida atual em relação à vida base
        //a divisão retorna um número decimal que define o tamanho da barra de vida (pois o tamanho total é 1)

        HealthPercentage = currentEarthLife / EarthLife * 100;

        Destroy(collision.gameObject);

        GameOver(); // testa a cada dano tomado se a vida zerou

        Debug.Log("Total Unstopped Asteroids: " + Counters.totalUnstoppedAsteroids);
        Debug.Log("Current Life: " + currentEarthLife);
        Debug.Log("Health Percentage: " + HealthPercentage + "%");
    }

    private static void GameOver()
    {
        if(currentEarthLife <= 0)
        {
            SceneManager.LoadScene("3.0-Main Menu");

            //Menu.gameOver = true;
            
            //pausar cena
            //reiniciar cena
            //salvar dados dos contadores

            //Debug.Log("GAME OVER");
        }
    }
}
