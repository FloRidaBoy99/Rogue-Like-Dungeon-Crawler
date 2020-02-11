using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public int hp;
    public bool hasDied;
    // Start is called before the first frame update
    void Start()
    {
        this.hasDied = false;
        this.hp = 6;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hp <= 0) hasDied = true;
        if (hasDied)
        {
            StartCoroutine("Die");
            //Destroy(gameObject);
        }
        


    }

    IEnumerator Die()
    {
        Debug.Log("Player has died :( ");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Dungeon");
    }
}
