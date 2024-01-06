using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class RollCommand : Command
{
    public override void Execute()
    {
        Roll();
    }

    void Roll()
    {
        Debug.Log("Roll");
    }
}