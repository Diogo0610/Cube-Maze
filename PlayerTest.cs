using UnityEngine;
using UnityEngine.UI;

public class PlayerTest : MonoBehaviour
{
    public Color32 playerColor;
    Renderer p_Renderer;
    public Text lifeText;
    void Start()
    {
        p_Renderer = GetComponent<Renderer>();
    }
    void Update()
    {
        playerColor = ChangePlayerColor.color;
        p_Renderer.material.color = playerColor;
        lifeText.color = ChangePlayerColor.textColor;
    }
}
