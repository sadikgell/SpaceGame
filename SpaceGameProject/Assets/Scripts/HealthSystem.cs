using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace SpaceGame
{
    public class HealthSystem : MonoBehaviour
    {
        public int maxHealth = 3;
        public int currentHealth;

        void Start()
        {
            currentHealth = maxHealth;
        }

        void FixedUpdate()
        {
            if (currentHealth <= 0)
            {
                Time.timeScale = 0f;
                //buraya oyun bitince maine atmayi ekleriz simdilik durdurma yaptim
            }
        }

        void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Meteor"))
            {
                TakeDamage(1);

                Destroy(collision.gameObject);
            }
        }

        void TakeDamage(int damageAmount)
        {
            currentHealth -= damageAmount;
        }
    }
}

