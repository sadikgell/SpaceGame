using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceGame
{
    public class RocketMovement : MonoBehaviour
    {
        //itiþ güçleri
        public float forwardForce = 13f;  
        public float sidewayForce = 5f;
        public float backwardForce = 12f;
        public float rotationSpeed = 3f;

        //power up seviyeleri
        public float nitroCharge = 100f;

        public Rigidbody rb;
        public Transform rotateTransform;
            

        void FixedUpdate()
        {
            //add force kullanýrken kontroller zorlaþtýðý için velocityi sistemine geçilecek
            rb.velocity = new Vector3(0, 0, forwardForce );
            //rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);


            if (Input.GetKey("d"))
            {
                rb.velocity += new Vector3(sidewayForce, 0, 0);
                //rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                rotateTransform.rotation *= Quaternion.Euler(0, -rotationSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("a"))
            {
                rb.velocity += new Vector3(-sidewayForce, 0, 0);
              //rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
              rotateTransform.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("s"))
            {
                rb.velocity += new Vector3(0, 0, -backwardForce);
                //rb.AddForce(0, 0, -backwardForce * Time.deltaTime, ForceMode.VelocityChange);
            }
            if (Input.GetKey("w"))
            {
                UseNitro(rb, forwardForce);
            }
        }
        
        public void UseNitro(Rigidbody player, float forwardForce)
        {
            if (nitroCharge > 0)
            {
                forwardForce += forwardForce;
                nitroCharge -= 30f * Time.deltaTime;
                
            }
        }
    }
}
