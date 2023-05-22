using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ColliderDetector : MonoBehaviour
{
    private bool isCrashed = false;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.name == "GateDetector" && isCrashed == false)
        {
            Debug.Log("Gate passed!");

        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.Contains("Quad"))
        {
            isCrashed = true;
            Debug.Log("Plane crashed! Game Over");
        }
    }
}
