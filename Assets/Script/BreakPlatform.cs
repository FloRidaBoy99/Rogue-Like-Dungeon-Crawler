using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakPlatform : MonoBehaviour
{
    public GameObject platform;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine("Break");
    }

    IEnumerator Break()
    {
        Debug.Log("Booom ");
        yield return new WaitForSeconds(2);
        Destroy(platform);
    }
}