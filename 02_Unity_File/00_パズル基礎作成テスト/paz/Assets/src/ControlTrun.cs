using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTrun : MonoBehaviour
{
    private int turn = 0;//0:PAZURU 1:ATK 2:ENATK
    public GameObject controlField;
    public ControlField control_field;
    public GameObject controlChar;
    public ControlChar control_char;

    void start(){
      control_field = controlField.GetComponent<ControlField>();
      control_char = controlChar.GetComponent<ControlChar>();
    }

    public int getTurn(){
      return turn;
    }

    public void changeTurn(){
      turn = (turn+1)%3;
      control_field.flagResetAll();
      if(turn == 0){
        control_field.remakeField();
      }
      else if(turn == 1){
        control_char.roadField();
        control_char.flagReset();
      }
    }
}
