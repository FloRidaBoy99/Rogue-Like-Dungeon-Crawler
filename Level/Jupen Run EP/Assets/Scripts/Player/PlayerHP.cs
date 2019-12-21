using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    public float hp;
    public bool hasDied;
    public float damgeEffectPause = 0.3f;
    public bool isHit = false;
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

    void ApplyDamge(float damage)
    {
        if(isHit == false)
        {
            this.hp -= damage;
            StartCoroutine("DamageEffect");

        }
       
    }

    IEnumerator Die()
    {
        Debug.Log("Player has died :( ");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level1");
    }

    IEnumerator DamageEffect()
    {
        isHit = true;
        for (int i = 0; i < 20; ++i)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(damgeEffectPause);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(damgeEffectPause);
        }
        isHit = false;

    }
}
