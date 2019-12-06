using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("gameObject "+ collision.gameObject.tag+ " has died :(");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHP>().hasDied = true;
        }
        //Destroy(collision.gameObject);
    }
}
