using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendDamgeColiderObjects : MonoBehaviour
{
    public float damgeValue = float.MaxValue;
    private void OnTriggerEnter2D(Collider2D collision)
    {
            collision.gameObject.SendMessage("ApplyDamge", this.damgeValue, SendMessageOptions.DontRequireReceiver);  
    }
}
