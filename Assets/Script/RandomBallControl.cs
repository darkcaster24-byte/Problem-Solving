using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBallControl : MonoBehaviour
{
    // Rigidbody 2D bola
    private Rigidbody2D rigidBody2D;

    public float xInitialForce;
    public float yInitialForce;


    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();

        PushBall();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void PushBall()
    {
        float yRandomInitialForce = Random.Range(-yInitialForce, yInitialForce);
        float xRandomInitialForce = Random.Range(-xInitialForce, xInitialForce);

        rigidBody2D.AddForce(new Vector2(xRandomInitialForce, yRandomInitialForce));
  
    }
}
