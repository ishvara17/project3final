using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
    
{
    public float speed = 240;
    float currentSpeed = 45f;
    float targetSpeed = 70f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSpeed < targetSpeed)
        {
            currentSpeed += Time.deltaTime;
        }

        transform.Translate(Vector3.back * Time.deltaTime * currentSpeed);
    }
}
