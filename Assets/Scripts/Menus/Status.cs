using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Status : MonoBehaviour
{
    public void BackToOptionsMenu()
    {
        SceneManager.LoadScene("3.2-Options Menu");
    }
}
