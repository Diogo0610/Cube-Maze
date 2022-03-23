using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Movement
    public static float moveH;
    public static float moveV;
    public FixedJoystick joystickMove;

    void Update()
    {
        moveH = joystickMove.Horizontal;
        moveV = joystickMove.Vertical;
    }
}
