using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Hero_Controllers : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Text skortext;
    public float skor;
    public Transform cameraa;
    public GameObject panel;

private void Start()
{
    Time.timeScale = 1;
}

private void Update()
{
    if(rb.velocity.y > 0 && transform.position.y > skor)
    {
     skor = transform.position.y;
    }
    skortext.text = Mathf.Round(skor).ToString();

    if(cameraa.position.y > transform.position.y + 7f)
    {
    Time.timeScale = 0;
    panel.SetActive(true);
    }

    
}

    void FixedUpdate()
    {
        float MoveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 ( MoveX * speed , rb.velocity.y);
    }
    public void playSecene()
    {
        SceneManager.LoadScene(0);
    }

    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Metor")
        {
            
            Time.timeScale = 0;
            panel.SetActive(true);
        }
    }

}
