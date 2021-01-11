using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    private readonly float upForce = 200f;
    private bool isDead = false;
    private Rigidbody2D rb2D;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>(); // rigid body
        anim = GetComponent<Animator>(); // Animator
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
                anim.SetTrigger("Flap");
            }
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2D.velocity = Vector2.zero;
        isDead = true;
        anim.SetTrigger("Die");
        GameControl.instance.BirdDied();
    }
}
