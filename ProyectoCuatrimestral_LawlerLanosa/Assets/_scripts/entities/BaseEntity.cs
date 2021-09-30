using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Todos los obstaculos pueden heredar de esta clase, como el player
/// contiene TBD
/// </summary>
public abstract class BaseEntity : MonoBehaviour
{
    protected IMover movementType;

    public BaseEntity SetMovementType(IMover newMovementType)
    {
        this.movementType = newMovementType;

        return this;
    }
}
