using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundJump : MonoBehaviour
{
    static AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    public static void JumpSound()
    {
        sound.Play();
    }
}
