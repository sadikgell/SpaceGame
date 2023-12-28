using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace SpaceGame
{
    public class CameraPlayerFollow : MonoBehaviour
    {

        public Transform player;
        public Vector3 offset;

        // Update is called once per frame
        void Update()
        {
            transform.position = player.position + offset;
        }
    }
}