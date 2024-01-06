using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FireGunCommand : Command
{
    public override void Execute()
    {
        FireGun();
    }

    void FireGun()
    {
        Debug.Log("FireGun");
    }
}
