using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward2 : MonoBehaviour
{
    public float speed = 60;
    public ParticleSystem trailParticle;
    private GameManager gameManager;
    public int PointValue;
    public AudioClip good;
    public AudioClip bad;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * Time.deltaTime * speed);
        Instantiate(trailParticle, transform.position, trailParticle.transform.rotation);
    }


    // wanneer het projectiel een target raakt met een bad of good tag dan komen er punten bij de score
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bad"))
        {
            Destroy(gameObject);
            gameManager.UpdateScore(5);
            AudioSource.PlayClipAtPoint(bad, new Vector3(2, -1, -94));
        }
        else if (other.gameObject.CompareTag("good"))
        {
            Destroy(gameObject);
            gameManager.UpdateScore(-5);
            AudioSource.PlayClipAtPoint(good, new Vector3(2, -1, -94));
        }

    }
}
