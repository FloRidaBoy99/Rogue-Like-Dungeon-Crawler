using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamageController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("gameObject " + collision.gameObject.tag + " was hitted :(");
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerHP>().hp -= 1 ;
        }
        //Destroy(collision.gameObject);
    }
}
