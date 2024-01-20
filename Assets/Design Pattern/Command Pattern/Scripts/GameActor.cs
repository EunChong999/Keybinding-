using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActor : MonoBehaviour
{
    [SerializeField] InputHandler inputHandler;
    Command command;

    private void Update()
    {
        command = inputHandler.HandleInput();

        if (command)
        {
            command.Execute(GetComponent<GameActor>());
        }
    }

    public void FireGun()
    {
        Debug.Log("FireGun");
    }

    public void Jump()
    {
        Debug.Log("Jump");
    }

    public void SwapWeapon()
    {
        Debug.Log("SwapWeapon");
    }

    public void Lurch()
    {
        Debug.Log("Lurch");
    }
}
