using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWeaponCommand : Command
{
    public override void Execute(GameActor actor)
    {
        actor.SwapWeapon();
    }
}
