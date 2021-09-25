using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAdvance : IMover
{
    float speed;
    Transform myTransform;

    public SimpleAdvance(Transform transf, float speed = 6)
    {
        this.speed = speed;
        this.myTransform = transf;
    }
    public void Advance()
    {
        myTransform.position += Vector3.forward * speed * Time.deltaTime;
    }
}
