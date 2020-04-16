using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour


{
    public ParticleSystem explosionParticle;
    public ParticleSystem explosionParticle2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("projectile"))
        {
            Debug.Log("dead");
            Destroy(gameObject);
            Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
            Instantiate(explosionParticle2, transform.position, explosionParticle.transform.rotation);
        }


    }
    
}
