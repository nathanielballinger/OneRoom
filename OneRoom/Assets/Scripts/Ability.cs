using UnityEngine;
using System.Collections;

public abstract class Ability
{
    
    public float energyCost { get; protected set; }

    public abstract bool use(GridPoint point, Direction dir);

}
