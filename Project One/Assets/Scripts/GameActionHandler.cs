using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameActionHandler : MonoBehaviour
{
  public GameAction gameActionObj;
  public UnityEvent handlerEvent;

  void Starte()
  {
    gameActionObj.action = RaiseHandler;
  }

  public void RaiseHandler()
  {
    handlerEvent.Invoke();
  }
}
