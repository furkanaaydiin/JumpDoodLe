using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Text scoretext;
    public float score;
    public Transform camera;
    public GameObject gameOverPanel; 
    public AudioClip gameOver;
    public AudioClip zipla;
    public AudioSource audioSource;

    private bool isDead;

    private void Start()
    {
        isDead = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        if(rb.velocity.y > 0 && transform.position.y > score)
        {
            score = transform.position.y;
        }
        scoretext.text = Mathf.Round(score).ToString();

        if(camera.position.y > transform.position.y + 7f && !isDead)
        { 
            Time.timeScale = 0; 
            gameOverPanel.SetActive(true); 
            PlayAudio(gameOver); 
            isDead = true;
        }
    

    
    }

    void FixedUpdate()
    {
        var MoveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2 ( MoveX * speed , rb.velocity.y);
    }
    public void PlayScene()
    {
        SceneManager.LoadScene(0);
    }

    private void PlayAudio(AudioClip audioClip)
    {
        audioSource.clip = audioClip;
        audioSource.Play();
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Metor")
        {
            
            Time.timeScale = 0;
            PlayAudio(gameOver);
            gameOverPanel.SetActive(true);
        }
        if(col.gameObject.tag == "Platform")
        {
            PlayAudio(zipla);
        }
    }

}
