using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class Lists : ScriptableObject
{
   public List<string> stringLists;
   public List<int> intLists;
   public List<float> floatLists;

   public List<GameObject> gameObjectLists;

   public List<FloatData> floatDataLists;
}
