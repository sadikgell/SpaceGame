
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace SpaceGame
{
    public class LoadendSceene : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKey(KeyCode.P))
            {
                LoadLevel("endSceene");
            }
        }
        public void LoadLevel(string name)
        {
            SceneManager.LoadScene(name);
        }
        public void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Rocket"))
            {
                LoadLevel("endSceene");
            }
        }
    }
}
