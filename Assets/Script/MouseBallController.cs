using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseBallController : MonoBehaviour
{
    private Vector3 mousePosition;
    public float speed = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        transform.position = Vector2.Lerp(transform.position, mousePosition, speed);
        
    }
}
