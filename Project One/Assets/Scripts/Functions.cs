using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Messaging;
using UnityEngine;

public class Functions : MonoBehaviour
{
    public string playerName;
    private int myNumber;
    public float speed = 5;
    public GameObject player;
    public Color playerColor = Color.red;
    void Start()
    {
        ConfiGameObject();
    }

    private GameObject ConfiGameObject()
    {
        var newPlayer = Instantiate(player);
        newPlayer.layer = 0;
        //newPlayer.active = true;
        newPlayer.tag = "Player";
        newPlayer.transform.position = Vector3.zero;
        newPlayer.name = playerName;
        newPlayer.GetComponent<Renderer>().material.color = playerColor;
        return gameObject;
    }
    
    

    private void OnTriggerEnter(Collider other)
    {
        speed = IncreaseSpeed(multiplier: 2);
    }


    private float IncreaseSpeed(float multiplier)
    {
        return speed * multiplier;
    }

    private string WelcomePlayer()
    {
        return playerName + " Welcome to the game!!";
    }
    
    private int AddNNumbers( int a, int b)
    {
        print((a + b));
        return  a + b;
    }
    
    
}
