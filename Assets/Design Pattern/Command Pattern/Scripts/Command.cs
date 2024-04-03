using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

[System.Serializable]
public abstract class Command : MonoBehaviour
{
    public abstract void Execute(GameActor actor);

    public static implicit operator Command(FieldInfo v)
    {
        throw new NotImplementedException();
    }
}
