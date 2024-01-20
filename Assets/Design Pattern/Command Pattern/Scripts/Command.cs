using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Command : MonoBehaviour
{
    public abstract void Execute(GameActor actor);
}
