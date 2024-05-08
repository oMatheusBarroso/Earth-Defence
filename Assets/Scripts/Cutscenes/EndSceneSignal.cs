using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndSceneSignal : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("3.0-Main Menu");
    }
}
