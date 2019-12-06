using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int hp;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        hp = 1;
        damage = 1;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && hp >0)
        {
            collision.gameObject.GetComponent<PlayerHP>().hp -= damage;
        }
    }
}
