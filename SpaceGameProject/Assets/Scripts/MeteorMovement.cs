using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame
{
    using UnityEngine;

    public class MeteorMovement : MonoBehaviour
    {
        public float speed = 10f;
        private Transform rocket;
        public float startPosition = 100f;
        private bool meteorMoving = false;
        public float rotationSpeed = 5f;

        void Start()
        {
            rocket = GameObject.FindGameObjectWithTag("Rocket").transform;
        }

        void FixedUpdate()
        { 

            if (Mathf.Abs(transform.position.z - rocket.position.z) < startPosition)
            {
                meteorMoving = true;
            }

            if (meteorMoving)
            {
                transform.LookAt(rocket.position);

                transform.Translate(Vector3.forward * speed * Time.deltaTime);

                transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
                // calismiyor rotation buna sonra bakalim cozemedim o quentition falan vardi onlarla falan denedim olmadi
            }

            if (transform.position.z < rocket.position.z - 10)
            {
                Destroy(gameObject);
            }

        }
    }

}
