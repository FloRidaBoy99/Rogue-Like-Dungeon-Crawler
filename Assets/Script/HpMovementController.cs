using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpMovementController : MonoBehaviour
{
    private GameObject player;
    public float xMin;
    public float xMax;
    public float yMin;
    public float yMax;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    void LateUpdate()
    {

        CheckPlayerHp();
        float x = Mathf.Clamp(player.transform.position.x, xMin, xMax) - 5.5f;
        float y = Mathf.Clamp(player.transform.position.y, yMin, yMax) + 4;

        gameObject.transform.position = new Vector3(x, y, gameObject.transform.position.z);

    }

    void CheckPlayerHp()
    {
        switch (player.GetComponent<PlayerHP>().hp)
        {
            case 6:
                GetComponent<Animator>().SetInteger("HP", 6);
                break;

            case 5:
                GetComponent<Animator>().SetInteger("HP", 5);
                break;

            case 4:
                GetComponent<Animator>().SetInteger("HP", 4);
                break;

            case 3:
                GetComponent<Animator>().SetInteger("HP", 3);
                break;

            case 2:
                GetComponent<Animator>().SetInteger("HP", 2);
                break;

            case 1:
                GetComponent<Animator>().SetInteger("HP", 1);
                break;

            case 0:
                //Nope
                GetComponent<Animator>().SetInteger("HP", 0);
                break;

        }
    }
}
