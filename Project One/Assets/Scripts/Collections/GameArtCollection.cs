using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
   public List<GameArtData> collectionList;

   public void AddData(GameArtData obj)
   {
      if (!collectionList.Contains(obj))
      {
         collectionList.Add(obj);
      }
   }

   public void RemoveLastItem()
   {
      collectionList.RemoveAt(collectionList.Count - 1);
   }
   
}
