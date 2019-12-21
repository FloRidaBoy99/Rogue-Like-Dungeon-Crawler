using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovmentController : MonoBehaviour
{
    public int playerSpeed = 10;
    public bool faceRight = false;
    public int playerJumpPower = 1000;
    public float moveX;
    public bool isOnTheGround = true;
    public SendDamgeColider sendDamgeColiderR;
    public float slyingTime = 0.2f;
    bool isSlaying = false;
    bool hasWappon = false;
    public float damge = 1f;
    

    private void Start()
    {
        
       
        
    }

    void Update()
    {
        sendDamgeColiderR.damgeValue = damge;
        PlayerMove();
        PlayerJump();
        PlayerAttack();
    }

    void PlayerJump()
    {
        if (Input.GetButtonDown("Jump") && isOnTheGround)
        {
            isOnTheGround = false;
            Jump();
        }
    }

    void PlayerMove()
    {
        //Controls
        moveX = Input.GetAxis("Horizontal");
       
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
    void PlayerAttack()
    {
        if (Input.GetButtonDown("Fire1") && this.isSlaying == false && hasWappon == true)
        {
            this.isSlaying = true;
            GetComponent<Animator>().SetBool("isAttacking", true);
        }

        if (isSlaying)
        {
            this.sendDamgeColiderR.attacking = true;
            StartCoroutine("ResetIsSlaying");
        }
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isOnTheGround = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Stick")
        {
            hasWappon = true;
            GetComponent<Animator>().SetBool("hasStick", true);
            Destroy(collision.gameObject);
        }
        
    }



    IEnumerator ResetIsSlaying()
    {
        yield return new WaitForSeconds(this.slyingTime);
        this.isSlaying = false;
        this.sendDamgeColiderR.attacking = false;
        GetComponent<Animator>().SetBool("isAttacking", false);
    }
}
