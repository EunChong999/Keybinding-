using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Command buttonX;
    public Command buttonY;
    public Command buttonB;
    public Command buttonA;

    public Command HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.X)) return buttonX;
        else if (Input.GetKeyDown(KeyCode.Y)) return buttonY;
        else if (Input.GetKeyDown(KeyCode.B)) return buttonB;
        else if (Input.GetKeyDown(KeyCode.A)) return buttonA;

        return null;
    }

    public string KeyInput()
    {
        if (Input.GetKeyDown(KeyCode.X)) return "X";
        else if (Input.GetKeyDown(KeyCode.Y)) return "Y";
        else if (Input.GetKeyDown(KeyCode.B)) return "B";
        else if (Input.GetKeyDown(KeyCode.A)) return "A";

        return null;
    }
}
