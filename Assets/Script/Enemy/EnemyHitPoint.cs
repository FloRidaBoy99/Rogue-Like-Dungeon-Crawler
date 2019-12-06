using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitPoint : MonoBehaviour
{
    public GameObject Enemy;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Enemy.GetComponent<Enemy>().hp = 0;
            Destroy(Enemy);
            Destroy(gameObject);
        }
    }
}
