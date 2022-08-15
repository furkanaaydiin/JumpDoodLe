using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Contollers : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D col) 
    {
        Destroy(col.gameObject);
    }
}
