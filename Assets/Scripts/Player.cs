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

        if(SceneManager.GetActiveScene().ToString() == "FirstLevel")
        {
            startScreen.SetActive(true);
            player.transform.position = spawnPoint;
            player.SetActive(false);
        }
        else if(SceneManager.GetActiveScene().ToString() == "SecondLevel")
        {
            startScreen.SetActive(true);
            player.transform.position = spawnPoint;
            SceneManager.LoadScene("FirstLevel");
        }
        else
        {
            startScreen.SetActive(true);
            player.transform.position = spawnPoint;
            SceneManager.LoadScene("FirstLevel");
        }

    }
}
