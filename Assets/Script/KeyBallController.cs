using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBallController : MonoBehaviour
{
    public float speed = 10.0f;
 

    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rigidBody2D.velocity;

        if(Input.GetKey(KeyCode.W)){
            velocity.y = speed;
        }else if(Input.GetKey(KeyCode.S)){
            velocity.y = -speed;
        }else{
            velocity.y = 0.0f;
        }

        if(Input.GetKey(KeyCode.D)){
            velocity.x = speed;
        }else if(Input.GetKey(KeyCode.A)){
            velocity.x = -speed;
        }else{
            velocity.x = 0.0f;
        }

        rigidBody2D.velocity = velocity;

    }
}
