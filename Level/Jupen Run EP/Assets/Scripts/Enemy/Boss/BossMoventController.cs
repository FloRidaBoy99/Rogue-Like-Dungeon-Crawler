using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMoventController : MonoBehaviour
{
    public int speed = 1;
    public bool faceRight = false;
    public int x = 1;
    public SendDamgeColider sendDamgeColiderR;

    private void Start()
    {
        StartCoroutine("Attacking");
    }
    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector2(x, 0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, 0) * speed;

        if (hit.distance < 0.1f)
        {
            //x = x * (-1);
        }

        //gameObject.GetComponent<SpriteRenderer>().color = new Color(150f, 150f, 150f, 1f);
    }

  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            x = x * (-1);
            FlipEnemy();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag != "Player")
        {
            x = x * (-1);
            FlipEnemy();
        }
       
    }

    void FlipEnemy()
    {
        Vector2 localSacle = gameObject.transform.localScale;
        localSacle.x *= -1;
        transform.localScale = localSacle;
    }


    IEnumerator Attacking()
    {
        while (true)
        {
            gameObject.GetComponent<SpriteRenderer>().color = new Color(150f, 150f, 150f, 1f);
            this.sendDamgeColiderR.attacking = true;
            yield return new WaitForSeconds(5);
            gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
            this.sendDamgeColiderR.attacking = false;
            yield return new WaitForSeconds(5);
        }


    }
}
