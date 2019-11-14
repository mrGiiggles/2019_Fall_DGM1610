using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HlthUpCoroutine : MonoBehaviour
{
    public bool bandAid = true;
    public FloatData checkUp;

    public void firstAid()
    {
        StartCoroutine(HlthUp());
    }
    IEnumerator HlthUp()
    {
        while (bandAid)
        {
            yield return new WaitForSeconds(1f);
            checkUp.UpdateValue(1f);
        }
        
    }

    
    
}
