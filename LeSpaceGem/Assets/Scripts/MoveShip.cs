using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShip : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, speed);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }


        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            rb.velocity = new Vector2(speed, rb.velocity.y);
        }


        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);

        }
    }
}
