using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 50.0f;
    public float Xrange = 35.0f;
    public GameObject projectilePrefab;
    public bool isOnGround = true;
    public bool GameOver;
    public float timeBetweenShots = 0.3f;
    private float timestamp;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        // keep the player in bounds
        if (transform.position.x < -Xrange)
            transform.position = new Vector3(-Xrange, transform.position.y, transform.position.z);

        if (transform.position.x > Xrange)
            transform.position = new Vector3(Xrange, transform.position.y, transform.position.z);

        if (Time.time >= timestamp && (Input.GetKeyDown(KeyCode.Space)) )
        {
            //Launch a projectile from the player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
            timestamp = Time.time + timeBetweenShots;
        }
            //player input
            horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

    }

}
