using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerInput : MonoBehaviour
{
    protected RaycastHit lastMouseRay;

    public System.Action<Vector3> onFingerUp;

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID
        // Finger up, save target
        if (!PauseManager.instance.isPaused && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.GetTouch(0).position), out lastMouseRay))
            {
                onFingerUp(lastMouseRay.point);
            }

            Debug.Log(this.lastMouseRay);
        }
#endif
#if UNITY_EDITOR
        // Finger up, save target
        if (Input.GetMouseButtonUp(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out lastMouseRay))
            {
                onFingerUp(lastMouseRay.point);
            }

            Debug.Log(this.lastMouseRay.point);
        }
#endif
    }
}
