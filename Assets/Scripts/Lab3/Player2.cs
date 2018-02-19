using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour {

    public float maxSpeed = 3;
    public float speed = 15f;
    public float jumpPower = 250f;

    public bool grounded;

    private Rigidbody2D rb2d;
    private Animator anim;

    void Start()
    {
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal3")));

        if (Input.GetKeyDown(KeyCode.J))
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            transform.localScale = new Vector3(1, 1, 1);
        }


        if (Input.GetKeyDown(KeyCode.M) && grounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }

    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal3");

        //moving the player
        rb2d.AddForce((Vector2.right * speed) * h);

        //limiting the speed of the player

        if (rb2d.velocity.x > maxSpeed)
        {
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }

        if (rb2d.velocity.x < -maxSpeed)
        {
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }
    }
}
