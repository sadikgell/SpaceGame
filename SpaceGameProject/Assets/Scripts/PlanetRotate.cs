using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotate : MonoBehaviour
{
    public float rotateSpeed = 10f;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(-Vector3.up, rotateSpeed * Time.deltaTime);
    }
}
