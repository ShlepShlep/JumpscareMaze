using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody2D rigidbody;
    public GameObject startScreen;
    public Vector3 spawnPoint;
    public GameObject player;
    public GameObject jumpscarePhoto;
    public GameObject jumpscareCollision;
    public GameObject replayButton;
    public string nextSceneName;
    public AudioClip jumpscareSound;
    public AudioSource audioSource;
    public GameObject levelString;

    private void Start()
    {
        
        rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        // Set the sprite position to the mouse position
        Vector2 direction = (mousePosition - transform.position).normalized;

        rigidbody.velocity = new Vector2(direction.x * speed, direction.y * speed);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        
        /* if (SceneManager.GetActiveScene().ToString() == "FirstLevel")
        {
            startScreen.SetActive(true);
            player.transform.position = spawnPoint;
            player.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().ToString() == "SecondLevel")
        {
            
        }
        
        else
        {
            startScreen.SetActive(true);
            player.transform.position = spawnPoint;
            SceneManager.LoadScene("FirstLevel");
        }*/


        if (collision.gameObject.name.Contains("Wall"))
        {
            startScreen.SetActive(true);
            player.transform.position = spawnPoint;
            player.SetActive(false);
            SceneManager.LoadScene("FirstLevel");
            Cursor.visible = true;
        }
        else if (collision.gameObject.name == "Jumpscare")
        {
            jumpscarePhoto.SetActive(true);
            Invoke("ShowButton", 3);
            player.SetActive(false);
            levelString.SetActive(false);
            audioSource.clip = jumpscareSound;
            audioSource.Play();

        }
        else if (collision.gameObject.name.Contains("EndGoal"))
        {
            SceneManager.LoadScene(nextSceneName);
        }

    }

    void ShowButton()
    {
        replayButton.SetActive(true);
        Cursor.visible = true;
    }
}
