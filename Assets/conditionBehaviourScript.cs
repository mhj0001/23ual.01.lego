using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conditionBehaviourScript : MonoBehaviour
{
    int condition = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void add1()
    {
        condition = condition + 1;
    }

    void add2()
    {
        condition = condition + 2;
    }

    void add4()
    {
        condition = condition + 4;
    }

    void reset()
    {
        condition = 0;
    }
}
