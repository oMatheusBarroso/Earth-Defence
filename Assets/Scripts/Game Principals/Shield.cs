using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("smallAsteroid"))
        {
            Counters.totalAvoidedDamage += Asteroid.smallAsteroidDamage/PlayerLifeSystem.EarthLife * 100;
        }
        else if (collision.gameObject.tag.Equals("mediumAsteroid"))
        {
            Counters.totalAvoidedDamage += Asteroid.mediumAsteroidDamage / PlayerLifeSystem.EarthLife * 100;
        }
        else if (collision.gameObject.tag.Equals("bigAsteroid"))
        {
            Counters.totalAvoidedDamage += Asteroid.bigAsteroidDamage / PlayerLifeSystem.EarthLife * 100;
        }

        Counters.totalStoppedAsteroids += 1;
        Destroy(collision.gameObject);


        Debug.Log("Total Avoided Damage: " +Counters.totalAvoidedDamage + "% of your life");
        Debug.Log("Total Stopped Asteroids: " +Counters.totalStoppedAsteroids);
    }
}
