using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Conrollers : MonoBehaviour
{ 
     public GameObject prefeb;
     public float speed;
     public float maxX;
     public float minX;
     public float interval;  
    void Start()
    {
        InvokeRepeating("spawner" , interval,interval);
    }

    
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;

    }


    void spawner()
    {
        GameObject NewPlatform = Instantiate(prefeb);
        NewPlatform.transform.position = new Vector2(
        Random.Range(maxX,minX),transform.position.y +
        (Random.Range(0.5f,1f)));
    }
}
