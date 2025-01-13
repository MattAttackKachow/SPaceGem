using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.AddForce(transform.up * 50);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.velocity = new Vector2( rb.velocity.x, speed);

        }

        if (Input.GetKeyDown(KeyCode.A))
        {

            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }

        if (!Input.GetKeyDown(KeyCode.A))
        {

        }

        if (Input.GetKeyDown(KeyCode.D))
        {

            rb.velocity = new Vector2(speed, rb.velocity.y);
        }

        if (!Input.GetKeyDown(KeyCode.D))
        {


        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            rb.velocity = new Vector2(rb.velocity.x, -speed);

        }
    }
}
