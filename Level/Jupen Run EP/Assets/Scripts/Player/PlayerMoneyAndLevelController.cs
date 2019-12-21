using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMoneyAndLevelController : MonoBehaviour
{
    public GameObject exObject;
    public GameObject moneyObject;
    public int ex;
    public int money = 0;
    public int lv = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        exObject.gameObject.GetComponent<Text>().text = "Ex: "+ this.ex;
        moneyObject.gameObject.GetComponent<Text>().text = "Money: " + this.money;
        if(this.ex >= 100)
        {
            this.ex = 0;
            this.lv += 1;

        }

    }
}
