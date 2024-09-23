using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    // Set rotation speed
    public float rotationSpeed = 400f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // rotating propeller around the z axis
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
