using System.Collections;
using System.Collections.Generic;
using System.Security.AccessControl;
using UnityEngine;

public class Practice : MonoBehaviour
{
    private void update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SayHello();
        }
    }

    public void SayHello()
    {
        print("Hello World");
    }
}