using UnityEngine;

public class Platform_Contollers : MonoBehaviour
{
   
   private void OnCollisionEnter2D(Collision2D col)
   {
     if(col.gameObject.GetComponent<Rigidbody2D>().velocity.y <= 0)
     {
         col.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector3.up * 400f);
     }
   }
}
