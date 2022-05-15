using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour {

    private float speed = 0.01f;
    private bool vertical;
    // Start is called before the first frame update
    void Start() { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + speed);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - speed);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - speed, transform.position.y );
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + speed, transform.position.y);
        }
    }
}
