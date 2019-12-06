using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentController : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool faceRight = false;
    public int playerJumpPower = 1000;
    public float moveX;
   

    void Update()
    {
        PlayerMove();
    }

    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
        if(Input.GetButtonDown("Jump"))
        {
            Jump();
        }
        //Animation
        //Player DIRECTION
        if(moveX < 0.0f && faceRight == false)
        {
            FlipPlayer();
        }

        else if(moveX > 0.0f && faceRight == true)
        {
            FlipPlayer();
        }

        //Physics
        Vector2 velocity = new Vector2(moveX * playerSpeed, gameObject.GetComponent<Rigidbody2D>().velocity.y);
        gameObject.GetComponent<Rigidbody2D>().velocity = velocity;

    }

    void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector2.up * playerJumpPower);
    }

    void FlipPlayer()
    {
        faceRight = !faceRight;
        Vector2 localSacle = gameObject.transform.localScale;
        localSacle.x *= -1;
        transform.localScale = localSacle;
    }
}
