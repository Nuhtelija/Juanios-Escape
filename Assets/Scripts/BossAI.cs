﻿using UnityEngine;
using System.Collections;

public class BossAI : MonoBehaviour
{
    public float moveSpeed;
    public bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool notAtEdge;
    public Transform edgeCheck;
    public Transform groundCheck;
    public float groundCheckRadius;
    public float jumpHeight;
    public LayerMask whatIsGround;

    private GameObject player;
    public Vector2 positionDifference;
    private bool startFight = false;
    private bool grounded;
    // Use this for initialization
    void Start()
    {

        player = GameObject.Find("Player");

    }

    void FixedUpdate()
    {

        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);

    }

    // Update is called once per frame
    void Update()
    {
        if (startFight)
        {
            positionDifference = new Vector2(transform.position.x - player.transform.position.x, transform.position.y - player.transform.position.y);
            hittingWall = Physics2D.OverlapCircle(wallCheck.position, wallCheckRadius, whatIsWall);

            notAtEdge = Physics2D.OverlapCircle(edgeCheck.position, wallCheckRadius, whatIsWall);

            if (positionDifference.x < 0)
                moveRight = true;
            else
                moveRight = false;

            if (positionDifference.y < 0)
                Jump();

            if (hittingWall)
                moveRight = !moveRight;
            else if (hittingWall && !grounded)
            {
                moveRight = !moveRight;
                Jump();
            }

            if (!notAtEdge)
            {
                if (moveRight)
                {
                    if (positionDifference.x > 0)
                        moveRight = false;
                }
                else
                    Jump();

            }


            if (moveRight && grounded)
            {

                GetComponent<Rigidbody2D>().velocity = new Vector2(moveSpeed, GetComponent<Rigidbody2D>().velocity.y);
            }
            else if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-moveSpeed, GetComponent<Rigidbody2D>().velocity.y);

            }
        }
    }
    void Jump()
    {
        if (Random.Range(0f, 1f) > 0.5f)
            if (grounded)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(GetComponent<Rigidbody2D>().velocity.x, jumpHeight);
            }
    }

    public void Fight()
    {
        startFight = true;
    }

}



