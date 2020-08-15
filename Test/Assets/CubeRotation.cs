using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotation : MonoBehaviour
{
    private float rotationValue;
    public float rotationSpeed = 10;

    private void Start()
    {
        Application.targetFrameRate = 300;
        rotationValue = rotationSpeed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationValue, rotationValue, rotationValue);
    }
}
