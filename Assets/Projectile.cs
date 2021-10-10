using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 2.0f;
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

        float posx= gameObject.transform.position.x;
        float posy= gameObject.transform.position.y;
        if(posx==-8.0f){
            velocity.x = speed;
        }else if(posx==8.0f){
            velocity.x = -speed;
        }else if(posy==-4.2f){
            velocity.y = speed;
        }else if(posy==4.2f){
            velocity.y = -speed;
        }

        rigidBody2D.velocity = velocity;
    }

    private void OnTriggerEnter2D(Collider2D col) {
        string tag = col.gameObject.tag;
        if(tag == "Box"){
            Destroy(gameObject);
        }
        if(tag == "Ball"){
            Destroy(col.gameObject);
            GameManager.Instance.GameOver();
        }
    }
    
}
