using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Name : MonoBehaviour
{
  [SerializeField]UnityEngine.UI.Text textbox;
  public Text text;

  IEnumerator Start ()
  {
    for(int i = 0;i<text.texts.GetLength(0);i++){
      textbox.text = text.texts[i,0];
      yield return new WaitUntil(()=>Input.GetMouseButtonDown(0));
      yield return null;
    }
    textbox.text = "";
  }
}
