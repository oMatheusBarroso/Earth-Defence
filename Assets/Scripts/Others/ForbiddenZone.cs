using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForbiddenZone : MonoBehaviour
{
    public bool MenuSpawner;

    private static int abortedAsteroids;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("smallAsteroid") || 
            collision.gameObject.tag.Equals("mediumAsteroid") || 
            collision.gameObject.tag.Equals("bigAsteroid"))
        {
            Destroy(collision.gameObject);

            if (MenuSpawner = false)
            {
                Counters.totalDeployedAsteroids -= 1;
                abortedAsteroids += 1;
            }
        }

        Debug.Log("Aborted Asteroid: " + abortedAsteroids);
    }
}
