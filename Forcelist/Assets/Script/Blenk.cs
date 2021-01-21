using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blenk : MonoBehaviour
{
    public float time;
    void Update()
    {
        time = time + Time.deltaTime;
        if(time >= 0.5)
        {
            GetComponent<Text>().enabled = true;
        }
        if(time >= 1)
        {
            GetComponent<Text>().enabled = false;
            time = 0;
        }
    }
}
