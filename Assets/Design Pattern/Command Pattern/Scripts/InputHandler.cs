using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public Command buttonSpace;
    public Command buttonLeftShift;
    public Command buttonTab;
    public Command buttonLeftControl;

    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) buttonSpace.Execute();
        else if (Input.GetKeyDown(KeyCode.LeftShift)) buttonLeftShift.Execute();
        else if (Input.GetKeyDown(KeyCode.Tab)) buttonTab.Execute();
        else if (Input.GetKeyDown(KeyCode.LeftControl)) buttonLeftControl.Execute();
    }
}
