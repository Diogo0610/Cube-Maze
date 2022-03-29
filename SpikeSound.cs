using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeSound : MonoBehaviour
{
    static AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public static void SpikeTouchSound()
    {
        sound.Play();
    }
}
