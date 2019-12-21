using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendDamgeColider : MonoBehaviour
{
    public float damgeValue = 1f;
    public bool attacking = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    Debug.Log("Hallllo");
    //    other.gameObject.SendMessage("ApplyDamge", damgeValue, SendMessageOptions.DontRequireReceiver);
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(attacking)
        {
            collision.gameObject.SendMessage("ApplyDamge", damgeValue, SendMessageOptions.DontRequireReceiver);
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (attacking)
        {
            collision.gameObject.SendMessage("ApplyDamge", damgeValue, SendMessageOptions.DontRequireReceiver);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (attacking)
        {
            collision.gameObject.SendMessage("ApplyDamge", damgeValue, SendMessageOptions.DontRequireReceiver);
        }
    }
}
