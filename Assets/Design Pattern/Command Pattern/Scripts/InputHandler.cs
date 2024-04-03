using System.Reflection;
using Unity.VisualScripting;
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
        FieldInfo[] members = typeof(InputHandler).GetFields(BindingFlags.Public
                | System.Reflection.BindingFlags.NonPublic
                | System.Reflection.BindingFlags.Static
                | System.Reflection.BindingFlags.Instance);

        foreach (var member in members)
        {
            if (member.Name == from)
            {
                Command temp = (Command)member.GetValue(this);
                continue;
            }

            if (member.Name == to) 
            {

            }

            Debug.Log(temp.ToString());
            //Debug.Log(member.Name);
            //Debug.Log(member.FieldType);
        }
    }
}
