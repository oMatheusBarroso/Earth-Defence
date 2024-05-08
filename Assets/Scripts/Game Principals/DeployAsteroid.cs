using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeployAsteroid : MonoBehaviour
{
    public Transform Spawner;
    private Vector2 spawnerPosition;

    public int RandomRangeXnum01;
    public int RandomRangeXnum02;

    public int RandomRangeYnum01;
    public int RandomRangeYnum02;

    [SerializeField]
    private GameObject[] _Asteroids; //array dos prefabs, definir tamanho no Unity Editor
    private float[] _respawnTime = new float[] {5, 5, 6, 6, 7, 7, 7, 7, 8, 8, 8, 9, 9, 10, 30};

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
            ((spawnerPosition.x + Random.Range(RandomRangeXnum01, RandomRangeXnum02)), 
            (spawnerPosition.y + Random.Range(RandomRangeYnum01, RandomRangeYnum02))); //local de spawn do objeto (coordenadas do spawner)

        //contagem de asteroides
        Counters.totalDeployedAsteroids += 1;
        Debug.Log("Total Deployed Asteroids: " + Counters.totalDeployedAsteroids);
    }

    IEnumerator AsteroidWave()
    {
        while (Menu.gameStarted = true)
        {
            var number2 = Random.Range(0, _respawnTime.Length);
            yield return new WaitForSeconds(_respawnTime[number2]);
            SpawnAsteroid();
        }
    }
}
