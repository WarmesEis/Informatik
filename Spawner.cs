using System.Numerics;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public float time = 0; // dient als timer fuer die spawnrate
    public GameObject Waffe; //Bezugsnahme auf das Objekt was gespawnt wird
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }
    // Update is called once per frame
    void Update()
    {
        /*Vector3 spawnpoint1  = new Vector3(5,1,0);*/
        if (time < 10){
            time = time + Time.deltaTime; //Time/deltaTime stellt sicher, dass es unabhaengig von der framerate hochzaelt
        }
        if (time >= 10){ 
            Instantiate(Waffe);
            time = 0;
        }
        
    }
    
    
}


