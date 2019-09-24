using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFroot : MonoBehaviour
{
    public bool appleIsRipe, orangeIsRipe, peachIsRipe;
    // Start is called before the first frame update
    void Start()
    {
        if (appleIsRipe)
        {
            print("Go Pick the Apple");
        }
        else if (orangeIsRipe)
        {
            print("Go Pick the Orange");
        } else if (peachIsRipe)
        {
            print("Go Pick the Peach");
        }
        else
        {
            print("Nothing is Ripe");
        }
        
    }

    
}
