using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreSaver : MonoBehaviour
{
    public float score = 1;
    public float scoreMultiplier = 15;
    public void ScoreUp(float point)
    {
        score += point * scoreMultiplier *Time.deltaTime ; 
    }
}
