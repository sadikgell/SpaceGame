using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMaker : MonoBehaviour
{
    protected float delayTimer = 5f;
    protected float repeatTimer = 1f;
    public GameObject meteor;
    public Transform spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnEnemy", repeatTimer, delayTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        Instantiate(meteor,spawnPos);
       
    }
}
