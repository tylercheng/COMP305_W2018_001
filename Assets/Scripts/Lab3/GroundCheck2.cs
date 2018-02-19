using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck2 : MonoBehaviour {

    private Megaman megaman;

    void Start()
    {
        megaman = gameObject.GetComponentInParent<Megaman>();
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        megaman.grounded = true;
    }

    void OnTriggerStay2D(Collider2D col)
    {
        megaman.grounded = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        megaman.grounded = false;
    }
}
