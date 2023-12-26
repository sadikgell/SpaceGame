using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceGame
{
    public class RocketMovement : MonoBehaviour
    {
        public float forwardForce = 13f;  
        public float sidewayForce = 5f;
        public float backwardForce = 12f;
        public float rotationSpeed = 3f;

        public Rigidbody rb;
        public Transform rotateTransform;

        void FixedUpdate()
        {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);

            rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);


            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                rotateTransform.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                rotateTransform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("s"))
            {
                rb.AddForce(0, 0, -backwardForce * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey("w"))
            {
                rb.AddForce(forwardForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }
    }
}
