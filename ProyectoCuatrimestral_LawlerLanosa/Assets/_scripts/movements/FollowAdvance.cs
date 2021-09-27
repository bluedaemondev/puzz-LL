using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowAdvance : IMover
{
    float speed;
    Transform myTransform;
    Transform targetTransform;

    public FollowAdvance(Transform transf, Transform target, float speed = 6)
    {
        this.myTransform = transf;
        this.targetTransform = target;
        this.speed = speed;
    }
    public Vector3 Advance()
    {
        return (targetTransform.position - myTransform.position).normalized * speed * Time.deltaTime;
    }
}
