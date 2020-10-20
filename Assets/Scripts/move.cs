using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    [SerializeField]
    float movemeentSpeed = 0.12f;

    [SerializeField]
    float jump = 16f;

    Rigidbody2D rb;
    bool isJump;

    SpriteRenderer sprite;
    void Start()
    {
        isJump = false;
        sprite = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-1 * movemeentSpeed, 0));
            sprite.flipX = true;
        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(movemeentSpeed, 0));
            sprite.flipX = false;
        }
        if (Input.GetButtonDown("Jump") && !isJump)
        {
            rb.velocity = new Vector2(0, jump);
            isJump = true;
        }

            if (Mathf.Abs(rb.velocity.y) < 0.01f)
                isJump = false;

    }
}
