using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurescript : MonoBehaviour
{
    public enum States
    {
        tavern,
        bar,
        table,
        order,
        food,
        drink
    };

    public States currentstate;
    
    // Start is called before the first frame update
    void Start()
    {
        currentstate = States.tavern;
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentstate)
        { case States.tavern:
            tavern();
            break;
            
        }
        
    }
}
