using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class JumpCommand : Command
{
    public override void Execute()
    {
        Jump();
    }

    void Jump()
    {
        Debug.Log("Jump");
    }
}
