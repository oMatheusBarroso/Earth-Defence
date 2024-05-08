using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroidMenu : MonoBehaviour
{
    public bool MainMenu;
    public Transform Spawner;
    private Vector2 spawnerPosition;

    public int RandomRange01RespawnTime;
    public int RandomRange02RespawnTime;

    public int RandomRangeXnum01;
    public int RandomRangeXnum02;

    [SerializeField]
    private GameObject[] _Asteroids; //array dos prefabs, definir tamanho no Unity Editor

    void Start()
    {
        spawnerPosition = Spawner.transform.position;
        StartCoroutine(AsteroidWave());
    }

    private void SpawnAsteroid()
    {
        var number = Random.Range(0, _Asteroids.Length); //aleatorização de número de posição do array
        GameObject Asteroid = Instantiate(_Asteroids[number]) as GameObject; //dar spawn do objeto
        _Asteroids[number].transform.position = new Vector2
            (Random.Range(RandomRangeXnum01, RandomRangeXnum02), spawnerPosition.y); //local de spawn do objeto (coordenadas do spawner)
    }
    IEnumerator AsteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(RandomRange01RespawnTime, RandomRange02RespawnTime));
            SpawnAsteroid();
        }
    }
}
