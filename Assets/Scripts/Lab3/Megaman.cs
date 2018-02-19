using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Megaman : MonoBehaviour {

    public float maxSpeed = 3;
    public float speed = 15f;
    public float jumpPower = 250f;

    public bool grounded;

    private Rigidbody2D rb2d;
    private Animator anim;

    void Start () {
		rb2d = gameObject.GetComponent<Rigidbody2D>();
        anim = gameObject.GetComponent<Animator>();
    }
	
	void Update () {
        anim.SetBool("Grounded", grounded);
        anim.SetFloat("Speed", Mathf.Abs(Input.GetAxis("Horizontal2")));

        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.localScale = new Vector3(-3, 3, 3);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            transform.localScale = new Vector3(3, 3, 3);
        }


        if (Input.GetKeyDown(KeyCode.V) && grounded)
        {
            rb2d.AddForce(Vector2.up * jumpPower);
        }
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal2");

        rb2d.AddForce((Vector2.right * speed) * h);

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
