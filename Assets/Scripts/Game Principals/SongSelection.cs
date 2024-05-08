using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SongSelection : MonoBehaviour
{
    public AudioClip[] Songs;
    public AudioSource Speaker;

    void Start()
    {
        PlayerPrefs.GetInt("Current Music", 0);
        Speaker.PlayOneShot(Songs[OptionsMenu.inGameMusic]);
    }
}
