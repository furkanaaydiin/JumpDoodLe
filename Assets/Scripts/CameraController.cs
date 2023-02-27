using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform Furkan;
    public Transform  BackGround;
    private void FixedUpdate()
    {
        if(Furkan.position.y >= transform.position.y)
        {
            transform.position = new Vector3 (
                transform.position.x,
                Furkan.position.y,
                transform.position.z
            );
        }
        if(transform.position.y >  BackGround.position.y + 10.56f)
        {
             BackGround.position = new Vector2(BackGround.position.x, transform.position.y + 10.56f);
        } 
    }
}