using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    Vector3 offset;
    float proppelerSpeed = 400f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, proppelerSpeed * Time.fixedDeltaTime);
    }
}
