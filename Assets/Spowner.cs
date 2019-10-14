using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spowner : MonoBehaviour
{

    public float spawnRate = 1f;
    public GameObject hexagonprefabs;

    private float nextTimeToSpaw = 2f;

  
    void Update()
    {
        if(Time.time >= nextTimeToSpaw){
            Instantiate(hexagonprefabs, Vector3.zero, Quaternion.identity);
            nextTimeToSpaw = Time.time + 1f /spawnRate;    
        }
        

        
    }
}
