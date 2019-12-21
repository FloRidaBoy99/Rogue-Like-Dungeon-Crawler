using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("USA");
        //Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        //collision.transform.GetComponent<Collider2D>().enabled = true;
        //GetComponent<Collider2D>().enabled = true;

        //Destroy(collision.gameObject);
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("USA2");
    }
}
