using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
namespace SpaceGame
{
    public class RocketMovement : MonoBehaviour
    {
        //itiþ güçleri
        public float forwardForce = 30f;
        public float nitroForwardForce = 90f;
        public float sidewayForce = 15f;
        public float backwardForce = 25f;
        public float rotationSpeed = 30f;

        //power up seviyeleri
        public float nitroCharge = 100f;

        public Rigidbody rb;
        public Transform rotateTransform;

        
        private void Start()
        {
            
        }

        void FixedUpdate()
        {
            
            
            if (Input.GetKey("d"))
            {
                rb.velocity += new Vector3(sidewayForce, 0, 0);
                
                rotateTransform.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("a"))
            {
                rb.velocity += new Vector3(-sidewayForce, 0, 0);
              
              rotateTransform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("s"))
            {
                rb.velocity += new Vector3(0, 0, -backwardForce);
                
            }
            if (Input.GetKey("w") && nitroCharge > 0)
            {
                UseNitro(rb);
            }
            else
            {
                rb.velocity = new Vector3(0, 0, forwardForce);
            }
        }
        
        public void UseNitro(Rigidbody player)
        {
            if (nitroCharge > 0)
            {
                rb.velocity = new Vector3(0, 0, nitroForwardForce);
                nitroCharge -= 30f * Time.deltaTime;
            }
        }
    }
}
