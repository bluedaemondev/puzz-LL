using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Setea un trigger de animator en OnCollisionEnter
/// </summary>
public class SetTriggerOnEnter : MonoBehaviour
{
    // Juan Lanosa

    public bool destroysAfterTrigger = false;
    public LayerMask interactsWith;

    [SerializeField]
    private string triggerName;

    private void OnTriggerEnter(Collider other)
    {
        // Ojito con las layer mask, tengo esto de aca abajo para hacerlo en desktop pero en mobile es
        // demasiado pesado el algoritmo

        //if (!Common.GetLayersFromMask(interactsWith).Contains(other.gameObject.layer))
        //    return;

        other.GetComponent<Animator>().SetTrigger(triggerName);
        
        if (destroysAfterTrigger)
            Destroy(this.gameObject);
    }

}
