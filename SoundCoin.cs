using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundCoin : MonoBehaviour
{
    static AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public static void CoinSound()
    {
        sound.Play();
    }
}
