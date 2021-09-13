using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRotate : MonoBehaviour
{
    //Decide the speed for the rotation
    private float rotationSpeed = 2000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Make the propeller rotate at the z axis
        transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
    }
}
