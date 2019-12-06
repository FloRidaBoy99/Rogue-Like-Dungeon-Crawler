using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakCollisun : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine("Break");
    }

    IEnumerator Break()
    {
        Debug.Log("Booom ");
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }
}
