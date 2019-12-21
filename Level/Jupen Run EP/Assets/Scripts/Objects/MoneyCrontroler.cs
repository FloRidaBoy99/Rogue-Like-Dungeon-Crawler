using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyCrontroler : MonoBehaviour
{
    public int value = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag =="Player")
        {
            collision.gameObject.GetComponent<PlayerMoneyAndLevelController>().money += value;
            Destroy(gameObject);
        }
    }
}
