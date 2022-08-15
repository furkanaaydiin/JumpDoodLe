using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metor_Spawner : MonoBehaviour
{
    public GameObject metor;
    public float speed;
    public float maxX;
    public float minX;
    public float interval;
    void Start()
    {
         InvokeRepeating("Metorspawner" , interval,interval);
    }

    
    void Update()
    {
       transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void Metorspawner()
    {
        GameObject newMetor = Instantiate(metor);
        newMetor.transform.position = new Vector2(
            Random.Range(maxX,minX),transform.position.y +
            (Random.Range(0.5f,1f))

        );
    }
}
