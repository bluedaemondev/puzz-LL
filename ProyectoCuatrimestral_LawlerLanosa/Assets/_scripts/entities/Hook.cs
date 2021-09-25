using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hook
{
    private Transform bodyToMove;
    private Vector3 targetPosition;

    private IMover mover;

    private Func<Vector3> moveHandler;

    // Start is called before the first frame update
    public Hook SetHookMover(IMover newMovementType)
    {
        this.mover = newMovementType;
        if (mover == null)
            moveHandler = () => { return Vector3.zero; };
        else
            moveHandler = newMovementType.Advance();

        return this;
    }
    public Hook SetTargetPosition(Vector3 newTarget)
    {
        this.targetPosition = newTarget;
        return this;
    }

    public Hook SetBodyTransform(Transform bodyToMoveTransform)
    {
        this.bodyToMove = bodyToMoveTransform;
        return this;
    }

    public void ArtificialUpdate()
    {
        bodyToMove.position += moveHandler();
    }



}
