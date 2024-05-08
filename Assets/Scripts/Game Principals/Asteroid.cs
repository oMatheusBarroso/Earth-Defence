using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public static float baseAsteroidDamage = 10f; //era double

    private static float smallAsteroidMultiplier = 1f; //era double
    private static float mediumAsteroidMultiplier = 1.5f; //era double
    private static float bigAsteroidMultiplier = 4f; //era double

    public static float smallAsteroidDamage = baseAsteroidDamage * smallAsteroidMultiplier; //era double
    public static float mediumAsteroidDamage = baseAsteroidDamage * mediumAsteroidMultiplier; //era double
    public static float bigAsteroidDamage = baseAsteroidDamage * bigAsteroidMultiplier; //era double
}
