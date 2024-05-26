using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    //public float speed = 5;
    Animator animator;

    Vector2 direction;
    public float force;
    public bool isRelative = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        /*float hor = Input.GetAxis("Horizontal");
        Vector2 direction = Vector2.right * hor;
        rb.velocity = new Vector2(direction.x * speed, rb.velocity.y);

        animator.SetFloat("hor", Mathf.Abs(hor));

        if (hor > 0)
        {
            transform.localScale = new Vector2(6.7f, 6.7f);
        }
        else if (hor < 0)
        {
            transform.localScale = new Vector2(-6.7f, 6.7f);
        }*/

        float hor = Input.GetAxis("Horizontal");
        direction = new Vector2(hor, 0);

        if (!isRelative)
        {
            rb.AddForce(direction * force, ForceMode2D.Impulse);
        }
        else
        {
            rb.AddRelativeForce(direction * force);
        }

    }
}