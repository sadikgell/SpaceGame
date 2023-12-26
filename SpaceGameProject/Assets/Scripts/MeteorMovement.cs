using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame
{
    using UnityEngine;

    public class MeteorMovement : MonoBehaviour
    {
        public float speed = 5f;
        private Transform rocket;

        void Start()
        {
            rocket = GameObject.FindGameObjectWithTag("Rocket").transform;
        }

        void Update()
        {
            transform.LookAt(rocket.position);

            transform.Translate(Vector3.forward * speed * Time.deltaTime);

        }
    }

}
