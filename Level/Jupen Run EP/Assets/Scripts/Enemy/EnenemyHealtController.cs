using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnenemyHealtController : MonoBehaviour
{
    public float hp = 1;
    public bool isHit = false;
    public float damgeEffectPause = 0.3f;
    public GameObject wall;
    public int expi = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    
    void Update()
    {
        if(this.hp <= 0)
        {
            if (gameObject.tag =="Boss")
            {
                Destroy(wall);
            }
             Destroy(gameObject);
            GameObject.FindWithTag("Player").GetComponent<PlayerMoneyAndLevelController>().ex += expi;

        }
    }

    void ApplyDamge(float damage)
    {

        if (isHit == false)
        {
            this.hp -= damage;
            StartCoroutine("DamageEffect");

        }
    }


    IEnumerator DamageEffect()
    {
        isHit = true;
        for (int i = 0; i < 5; ++i)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            yield return new WaitForSeconds(damgeEffectPause);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            yield return new WaitForSeconds(damgeEffectPause);
        }
        isHit = false;

    }
}
