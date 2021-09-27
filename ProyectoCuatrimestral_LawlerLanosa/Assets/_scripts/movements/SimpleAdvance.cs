using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAdvance : IMover
{
    float speed;
    Vector3 bodyPosition;

    public SimpleAdvance(Transform transf, float speed = 6)
    {
        this.speed = speed;
        this.bodyPosition = transf.position;
    }
    public Vector3 Advance()
    {
        bodyPosition += Vector3.forward * speed * Time.deltaTime;
        return bodyPosition;
    }
    
}
