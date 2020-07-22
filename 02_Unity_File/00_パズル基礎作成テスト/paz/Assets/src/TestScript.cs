using UnityEngine;

public class TestScript : MonoBehaviour {
    //クリックしたとき
    void OnMouseDown()
    {
        Debug.Log("OnMouseDown");
        transform.Translate(0,0.1f,0);
    }

    public int get(){
      return 0;
    }

    void Update(){
      //transform.Translate(0,0.005f,0);
    }
}
