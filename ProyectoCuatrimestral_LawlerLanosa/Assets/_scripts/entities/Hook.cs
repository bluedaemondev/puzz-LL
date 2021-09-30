using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Hook
{
    private Transform _bodyToMove;
    private Vector3 _targetPosition;
    private LineRenderer _rendererHook;

    public Hook()
    {
        this._rendererHook = null;
    }
    public Hook(LineRenderer rendererHook)
    {
        this._rendererHook = rendererHook;
    }

    public Hook SetTargetPosition(Vector3 newTarget)
    {
        this._targetPosition = newTarget;
        OnUpdateRope();
        return this;
    }

    public Hook SetBodyTransform(Transform bodyToMoveTransform)
    {
        this._bodyToMove = bodyToMoveTransform;
        OnUpdateRope();
        return this;
    }
    public void OnUpdateRope()
    {
        if (_rendererHook == null)
            return;

        this._rendererHook.SetPositions(new Vector3[0]);

        this._rendererHook.SetPosition(0, _bodyToMove.position);
        this._rendererHook.SetPosition(1, _targetPosition);
    }



}
