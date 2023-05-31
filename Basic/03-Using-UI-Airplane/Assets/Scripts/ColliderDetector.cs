using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ColliderDetector : MonoBehaviour
{
    public Timer timeSlider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "GateDetector")
        {
            Debug.Log("Gate passed!");
            timeSlider.UpdateTimer();
            timeSlider.UpdateCounter();

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Plane crashed! Game Over");
    }

    private void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Did Hit");
        }
    }
}
