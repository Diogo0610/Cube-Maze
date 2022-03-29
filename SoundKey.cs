using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundKey : MonoBehaviour
{
    static AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public static void KeySound()
    {
        sound.Play();
    }
}
