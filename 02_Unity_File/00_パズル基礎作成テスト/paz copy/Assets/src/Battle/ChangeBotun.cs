using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeBotun : MonoBehaviour
{
  public GameObject controlTrun;
  public ControlTrun control_turn;
  void Start()
  {
    control_turn = controlTrun.GetComponent<ControlTrun>();
  }
  void OnMouseDown(){
    control_turn.changeTurn();
    Debug.Log(control_turn.getTurn());
  }
}
