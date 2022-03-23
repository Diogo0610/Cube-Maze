using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
    Color System Scripts:
    Player.cs, PlayerColor.cs, ChangePlayerColor.cs
*/
public class ChangePlayerColor: MonoBehaviour
{
    public static Color32 color;
    public static Color32 textColor;
    
    private void Update()
    {
        PlayerColor.colorIndex = PlayerPrefs.GetInt("PlayerColor");

        if (PlayerColor.colorIndex == 0)
        {
            color = new Color32(255, 255, 255, 255); // white
            textColor = new Color32(195, 195, 195, 255); // gray
        }
        else if (PlayerColor.colorIndex == 1)
        {
            color = new Color32(243, 241, 88, 255); // yellow
            textColor = new Color32(150, 148, 25, 255); //yellow
        }
        else if (PlayerColor.colorIndex == 2)
        {
            color = new Color32(125, 255, 102, 255); // green
            textColor = new Color32(27, 183, 0, 255); //green
        }
        else if (PlayerColor.colorIndex == 3)
        {
            color = new Color32(255, 88, 88, 255); // red
            textColor = new Color32(192, 37, 37, 255); //red
        }
        else if (PlayerColor.colorIndex == 4)
        {
            color = new Color32(83, 172, 233, 255); // blue
            textColor = new Color32(45, 80, 180, 255); // blue
        }
        else if (PlayerColor.colorIndex == 5)
        {
            color = new Color32(52, 255, 175, 255); // blue green
            textColor = new Color32(15, 180, 114, 255); // blue green
        }
        else if (PlayerColor.colorIndex == 6)
        {
            color = new Color32(255, 121, 233, 255); // pink
            textColor = new Color32(202, 14, 171, 255); // pink
        }
        else if (PlayerColor.colorIndex == 7)
        {
            color = new Color32(255, 187, 57, 255);
            textColor = new Color32(248, 163, 0, 255);
        }
        else if (PlayerColor.colorIndex == 8)
        {
            color = new Color32(148, 71, 226, 255);
            textColor = new Color32(98, 0, 198, 255);
        }
        else if (PlayerColor.colorIndex == 9)
        {
            color = new Color32(210, 255, 107, 255);
            textColor = new Color32(178, 255, 0, 255);
        }
        else if (PlayerColor.colorIndex == 10)
        {
            color = new Color32(255, 90, 148, 255);
            textColor = new Color32(255, 0, 90, 255);
        }
        else if (PlayerColor.colorIndex == 11)
        {
            color = new Color32(136, 246, 255, 255);
            textColor = new Color32(0, 236, 255, 255);
        }
    }
}
