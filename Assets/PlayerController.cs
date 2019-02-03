using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb2d;      

    float moveVertical, moveHorizontal;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveHorizontal = Input.GetAxis("Horizontal");

        moveVertical = Input.GetAxis("Vertical");
    }
    private void Update()
    {
        if (moveVertical > 0)
        {
            rb2d.AddForce(transform.up * 2);
        }
        else if (moveVertical < 0)
        {
            rb2d.AddForce(transform.up * -2);
        }


        if (moveHorizontal > 0)
        {
            rb2d.AddForce(transform.right * 2);
        }
        else if (moveHorizontal < 0)
        {
            rb2d.AddForce(transform.right * -2);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D))
        {
            rb2d.velocity = Vector2.zero;
            rb2d.angularVelocity = 0;
        }
    }
}
