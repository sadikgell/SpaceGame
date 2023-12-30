using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreSaver : MonoBehaviour
{
    public Transform rocket;
    public float score;


    private void Update()
    {
        score = rocket.position.z;
    }

}
