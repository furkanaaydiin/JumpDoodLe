using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Conroller : MonoBehaviour
{
    public Transform furkan;
    public Transform Bacgraund;

    void Start()
    {
        
    }

   
    
    private void FixedUpdate()
    {
        if(furkan.position.y >= transform.position.y)
        {
            transform.position = new Vector3 (
                transform.position.x,
                furkan.position.y,
                transform.position.z
            );
        }
        if(transform.position.y >=Bacgraund.position.y + 10.56f)
        {
            Bacgraund.position = new Vector2(
                Bacgraund.position.x,
                transform.position.y + 10.56f
            );
        } 
    }
}