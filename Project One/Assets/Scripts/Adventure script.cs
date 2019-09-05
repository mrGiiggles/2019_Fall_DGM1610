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
            //Tavern();
            break;
        case States.bar:
            //Bar();
            break;
        case States.table:
            //Table();
            break;
        case States.food:
            //Food();
            break;
            
        
            
        }
        
    }

   // Tavern()
//    {
        
   // }
}
