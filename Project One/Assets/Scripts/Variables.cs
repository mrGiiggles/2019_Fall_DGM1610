﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Variables : MonoBehaviour
{
    public float floatValue = 5.5f;
    public int intValue = 6;
    public string stringValue = "Bob";
    public int firePower;
    public UnityEvent Event;

    private void OnTriggerEnter(Collider other)
    {
       Event.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
