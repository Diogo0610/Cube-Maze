using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallColors : MonoBehaviour
{
    Renderer w_Renderer;
    Color32 _wallColor;
    void Start()
    {
        _wallColor = new Color32(233, 233, 233, 255);
        w_Renderer = GetComponent<Renderer>();
        w_Renderer.material.color = _wallColor;
    }
}
