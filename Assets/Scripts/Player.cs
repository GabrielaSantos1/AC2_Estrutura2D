using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum PlayerState
{
    IDLE,
    WALK,
    JUMP
}

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    //public float speed = 5;
    Animator animator;
    public PlayerState state;

    Vector2 direction;
    public float force;
    public bool isRelative = false;

    private void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();

        state = PlayerState.IDLE;
    }

    void Update()
    {
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

        switch (state)
        {
            case PlayerState.IDLE:
                ChangeState(PlayerState.IDLE);
                break;
            case PlayerState.WALK:
                ChangeState(PlayerState.WALK);
                break;
            case PlayerState.JUMP:
                ChangeState(PlayerState.JUMP);
                break;
        }

    }
    public void ChangeState(PlayerState newState)
    {
        switch (newState)
        {
            case PlayerState.IDLE:
                break;
            case PlayerState.WALK:
                break;
            case PlayerState.JUMP:
                break;
        }
    }


}