using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseEntity
{
    [SerializeField] PlayerInput input;
    [SerializeField] Hook hook;

    // el player es responsable de su movimiento
    // tiene una clase de animator controller para manejar estados

    void Start()
    {
        this.movementType = new FollowAdvance(transform, transform.position);
        input.onFingerUp = Move;
    }

    private void Move(Vector3 posDestination)
    {
        print("cambiar esto");
        this.movementType.Advance();
    }
}
