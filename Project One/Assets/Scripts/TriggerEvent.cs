
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

    public UnityEvent triggerEnterEvent, triggerExitEvent;

    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
    
    private void OnTriggerExit(Collider other)
    {
        triggerExitEvent.Invoke();
    }
}
