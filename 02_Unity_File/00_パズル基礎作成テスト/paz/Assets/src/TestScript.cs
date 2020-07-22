using UnityEngine;

public class TestScript : MonoBehaviour {
    //クリックしたとき
    //マウスが乗った時
void OnMouseEnter()
{
    Debug.Log("OnMouseEnter");
}

//マウスが乗っている間、呼び出され続ける
void OnMouseOver()
{
    Debug.Log("OnMouseOver");
}

//マウスが離れたとき
void OnMouseExit()
{
    Debug.Log("OnMouseExit");
}

//クリックしたとき
void OnMouseDown()
{
    Debug.Log("OnMouseDown");
}

//クリックしてから、指を離したとき
void OnMouseUp()
{
    Debug.Log("OnMouseUp");
}

//クリックした後、”オブジェクト上で”　指を離したとき
void OnMouseUpAsButton()
{
    Debug.Log("MouseUpAsButton");
}

//クリックしてドラッグをしている間、呼び出され続ける
void OnMouseDrag()
{
    Debug.Log("MouseDrag");
}
}
