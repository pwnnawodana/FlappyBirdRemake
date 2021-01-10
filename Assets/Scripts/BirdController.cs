using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private float upForce = 200f;
    private readonly bool isDead = false;
    private Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDead.Equals(false))
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb2D.velocity = Vector2.zero; // set the bird's velocity to zero in each jump
                rb2D.AddForce(new Vector2(0, upForce));
            }
        }
    }
}
