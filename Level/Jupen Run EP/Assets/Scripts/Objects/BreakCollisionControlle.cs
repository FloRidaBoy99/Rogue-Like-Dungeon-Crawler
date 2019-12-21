﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakCollisionControlle : MonoBehaviour
{
    private bool isSet = false;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(isSet == false)
        {
            StartCoroutine("DestroyPlatform");
            isSet = true;
        }
        
    }

    IEnumerator DestroyPlatform()
    {
        gameObject.GetComponent<SpriteRenderer>().color = new Color(150f, 150f, 150f, 1f);
        yield return new WaitForSeconds(0.5f);

        gameObject.GetComponent<SpriteRenderer>().color = new Color(0f, 0f, 0f, 1f);
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
