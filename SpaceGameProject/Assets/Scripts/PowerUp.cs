using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpaceGame
{
    public class PowerUp : MonoBehaviour
    {
        private float nitroCharge = 100f;
        private float nitroUseRate = 5f;
        private bool shield = false;

        public bool Shield { get => shield; set => shield = value; }
        public float NitroCharge { get => nitroCharge; set => nitroCharge = value; }
        public float NitroUseRate { get => nitroUseRate; set => nitroUseRate = value; }
    }

    public class nitro : PowerUp
    {
        
        public static void UseNitro(Rigidbody player,float forwardForce,PowerUp nitro)
        {
            player.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
            
        }
    }
}
