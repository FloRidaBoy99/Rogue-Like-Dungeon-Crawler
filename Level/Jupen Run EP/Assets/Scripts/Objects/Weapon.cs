using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float multiplier = 1;
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    Debug.Log("U");
    //    if(collision.gameObject.tag =="Player")
    //    {
    //        Debug.Log("S");

    //    }
    //    if(collision.gameObject.GetComponent<PlayerMoneyAndLevelController>().money != -1)
    //    {
    //        Debug.Log("A");
    //    }
    //    //collision.GetComponent<PlayerMovmentController>().damge *= multiplier;
    //    //collision.GetComponent<PlayerMovmentController>().sendDamgeColiderR.damgeValue *= multiplier;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
         
           if(collision.gameObject.GetComponent<PlayerMovmentController>().damge == 1 && multiplier == 10)
            {
               
                collision.gameObject.GetComponent<PlayerMovmentController>().damge = 10;
                Debug.Log(collision.gameObject.GetComponent<PlayerMovmentController>().damge);
            }

            if (collision.gameObject.GetComponent<PlayerMovmentController>().damge == 10 && multiplier == 1)
            {
                collision.gameObject.GetComponent<PlayerMovmentController>().damge = 1;
                Debug.Log(collision.gameObject.GetComponent<PlayerMovmentController>().damge);
            }
            //Destroy(gameObject);
        }
    }
}
