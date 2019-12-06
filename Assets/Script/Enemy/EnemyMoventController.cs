using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoventController : MonoBehaviour
{
    public int speed = 10;
    public int x = 1;

    // Update is called once per frame
    void Update()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position,new Vector2(x,0));
        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(x, 0) * speed;

        if(hit.distance < 0.1f)
        {
            //x = x * (-1);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        x = x *(-1);
    }
}
