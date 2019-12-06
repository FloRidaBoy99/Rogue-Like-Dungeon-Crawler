using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLiveTimeController : MonoBehaviour
{
    // Start is called before the first frame update
    public int time;
    void Start()
    {
        time = 100;
    }

    // Update is called once per frame
    void Update()
    {
        time--;
        if(time < 0)
        {
            Destroy(gameObject);
        }
    }
}
