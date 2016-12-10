using UnityEngine;
using System.Collections;

public interface ICommandable
{
    // return true if successful
    bool moveTo(GridPoint point);

    // return true if successful
    bool useAbility(GridPoint point, Direction dir, Ability ability);
}
