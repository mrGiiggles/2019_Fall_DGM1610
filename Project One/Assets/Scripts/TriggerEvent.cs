﻿
using System;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]

public class TriggerEvent : MonoBehaviour
{
    private void Awake()
    {
      GetComponent <Collider>().isTrigger = true;
    }

    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}
