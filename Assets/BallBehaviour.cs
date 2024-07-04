using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviour : MonoBehaviour
{
    public float XRotation = 0;
    public float YRotation = 1;
    public float ZRotation = 0;
    public float DegreesPerSecond = 180;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 axis = new Vector3(XRotation, YRotation, ZRotation);
        // transform.Rotate(axis, DegreesPerSecond * Time.deltaTime); // rotate object around it's personal center
        transform.RotateAround(Vector3.zero, axis, DegreesPerSecond * Time.deltaTime); //rotate around a specific point (Vector3.zero being the center of the scence)
        Debug.DrawRay(Vector3.zero, axis, Color.yellow, .5f); //leaving a trail not of multiple rays isn't seeming to work?
    }
}
