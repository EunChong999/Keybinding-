using System.Reflection;
using Unity.VisualScripting;
using UnityEditor.PackageManager.UI;
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

    public void SwitchKey(string from, string to)
    {
        Command temp = (Command)GetType().GetField("button" + from).GetValue(this);
        GetType().GetField("button" + from).SetValue(this, (Command)GetType().GetField("button" + to).GetValue(this));
        GetType().GetField("button" + to).SetValue(this, temp);
    }
}
