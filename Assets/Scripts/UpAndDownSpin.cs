﻿using UnityEngine;


public class UpAndDownSpin : MonoBehaviour
{

    public float degreesPerSec = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    
    Vector3 posOffset = new Vector3();
    Vector3 tempPos = new Vector3();
    
    void Start()
    {
        posOffset = transform.position;
    }

    void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSec * 2, 0f), Space.World);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }
}