using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundSelect : MonoBehaviour
{
    static AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public static void SelectSound()
    {
        sound.Play();
    }
}
