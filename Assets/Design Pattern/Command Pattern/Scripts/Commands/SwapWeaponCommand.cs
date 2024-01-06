using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SwapWeaponCommand : Command
{
    public override void Execute()
    {
        SwapWeapon();
    }

    void SwapWeapon()
    {
        Debug.Log("SwapWeapon");
    }
}
