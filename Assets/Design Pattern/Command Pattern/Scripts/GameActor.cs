using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class GameActor : MonoBehaviour
{
    [SerializeField] InputHandler inputHandler;
    Command command;
    string str;
    StringBuilder sb = new StringBuilder();

    private void Update()
    {
        command = inputHandler.HandleInput();
        str = inputHandler.KeyInput();

        if (command)
        {
            command.Execute(GetComponent<GameActor>());
        }
    }

    public void FireGun()
    {
        sb.Append("FireGun");
        sb.Append("_");
        sb.Append(str);
        Debug.Log(sb);
        sb.Remove(0, sb.Length);
    }

    public void Jump()
    {
        sb.Append("Jump");
        sb.Append("_");
        sb.Append(str);
        Debug.Log(sb);
        sb.Remove(0, sb.Length);
    }

    public void SwapWeapon()
    {
        sb.Append("SwapWeapon");
        sb.Append("_");
        sb.Append(str);
        Debug.Log(sb);
        sb.Remove(0, sb.Length);
    }

    public void Lurch()
    {
        sb.Append("Lurch");
        sb.Append("_");
        sb.Append(str);
        Debug.Log(sb);
        sb.Remove(0, sb.Length);
    }
}
