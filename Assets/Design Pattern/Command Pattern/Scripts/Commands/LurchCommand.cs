using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LurchCommand : Command
{
    public override void Execute(GameActor actor)
    {
        actor.Lurch();
    }
}