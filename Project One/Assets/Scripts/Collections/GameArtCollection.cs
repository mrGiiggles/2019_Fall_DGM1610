using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
   public List<GameArtData> colletionList;

   public void AddData(GameArtData obj)
   {
       if (!obj.collected)
       {
           colletionList.Add(obj);
           obj.collected = true;
       }
   }
   
}
