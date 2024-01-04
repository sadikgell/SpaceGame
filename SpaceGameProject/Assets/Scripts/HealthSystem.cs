using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


namespace SpaceGame
{
    public class HealthSystem : MonoBehaviour
    {
        public int maxHealth = 2;
        public int currentHealth;

        void Start()
        {
            currentHealth = maxHealth;
        }

        void FixedUpdate()
        {
            if (currentHealth <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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

