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
}
