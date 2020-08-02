using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Talk : MonoBehaviour
{
  [SerializeField]UnityEngine.UI.Text textbox;
  public Text text;

  IEnumerator Start ()
  {
    for(int i = 0;i<text.texts.GetLength(0);i++){
      textbox.text = text.texts[i,1];
      yield return new WaitUntil(()=>Input.GetMouseButtonDown(0));
      yield return null;
    }
    SceneManager.LoadScene("Battle");
  }
}
