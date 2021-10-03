using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : BaseEntity
{
    [SerializeField] PlayerInput _input;
    [SerializeField] Hook _hook;
    [SerializeField] Animator _animator;

    // el player es responsable de su movimiento
    // tiene una clase de animator controller para manejar estados

    void Start()
    {
        this.movementType = new FollowAdvance(transform, transform.position);
        _input.onFingerUp = Move;
    }

    private void Move(Vector3 posDestination)
    {
        if (_animator)
        {
            _animator.SetBool("moving", true);
        }

        this.movementType.Advance();
    }
}
