using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;

public class DropSphere : MonoBehaviour
{
    public GameObject sphere;
    public float fallSpeed = 100f;

    public Rigidbody rb;
    public float zeroMass = 0f;
    public float heavyMass = 10f;

    void Update()
    {

        var dropKey = Input.GetKeyDown(KeyCode.Space);

        if (dropKey)
        {
            GameObject clone = Instantiate(sphere, sphere.transform.position, transform.rotation);

            rb = clone.AddComponent<Rigidbody>();
            rb.mass = heavyMass;

            //first i tryied script below and i have no idea why it doesnt work 
            //clone.transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);  

            Destroy(clone, 5);

        }

    }

}
