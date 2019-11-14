using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.XR.Interaction;

public class CouroutineClass : MonoBehaviour
{
    public bool canRun = true;
    public IntData index;
    public float seconds = 1f;
    private WaitForSeconds wfsObj;

    public void Run()
    {
        wfsObj = new WaitForSeconds(seconds);
        StartCoroutine(OnRun());

    }
    //IEnumerator Start()
    IEnumerator OnRun()
    {
        while (index.value > 0)
        {
            Debug.Log(index.value);
            index.value--;
            yield return wfsObj;
            
        }
        
        
    }

   
}
