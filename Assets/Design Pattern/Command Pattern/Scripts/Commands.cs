using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Commands
{
    public class FireGunCommand : Command
    {
        public override void Execute(GameActor actor)
        {
            actor.FireGun();
        }
    }

    public class JumpCommand : Command
    {
        public override void Execute(GameActor actor)
        {
            actor.Jump();
        }
    }

    public class LurchCommand : Command
    {
        public override void Execute(GameActor actor)
        {
            actor.Lurch();
        }
    }

    public class SwapWeaponCommand : Command
    {
        public override void Execute(GameActor actor)
        {
            actor.SwapWeapon();
        }
    }
}
