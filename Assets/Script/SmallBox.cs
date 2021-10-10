using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallBox : MonoBehaviour
{
    
    private void OnTriggerEnter2D(Collider2D col) {
        string tag = col.gameObject.tag;
        if(tag == "Ball"){
            Destroy(gameObject);
            GameManager.Instance.AddScore();
        }
    }
}
