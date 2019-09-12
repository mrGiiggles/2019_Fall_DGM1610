using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adventurescript : MonoBehaviour
{
    public enum States
    {
        tavern,
        inside,
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
            Tavern();
            break;
        case States.inside:
            Inside();
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

   private void Tavern()
    {
     print("You stand in front of Bloody Boot Tavern");
     if (Input.GetKeyDown(KeyCode.Space))
     {
         currentstate = States.inside;
     }

    }

   private void Inside()
   {
       print("You walk through the door. There's a table free far from the fire and a stool available at the bar");
       if (Input.GetKeyDown(KeyCode.Space)) { currentstate = States.bar;}
       if (Input.GetKeyDown(KeyCode.LeftAlt)) { currentstate = States.bar;}
   }
}
