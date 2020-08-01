using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Road : MonoBehaviour
{
  public int type;//道路のたいぷ 0:まっすぐ 1:曲がる　2:t字 3:cros
  public int spin;//回転してるか0:デフォルト　そこから右回転で+1
  public int[] able;//そこが通れるか[l,u,r,d]
  public int next_road;//0:l,1:u,2:r,3:d
  public bool flag = false;
  public bool flag2 = false;

    public int getType(){
      return this.type;
    }
    public int[] getAble(){
      return this.able;
    }
    public int getDeg(){
      int deg = spin*90;
      return deg;
    }
    public int getNext(int k){//来た方角
      if(type == 0){
         this.next_road = (k + 2)%4;
      }
      if(type == 1){
        for(int i = 0;i<4;i++){
          if(able[i]==1 && k!=i){
            this.next_road = i;
          }
        }
      }
      return this.next_road;
    }
    public void spinRoad(int r){//0:右回転　1:左回転
      if(r == 0){
        int stb = able[3];
        for(int i = 3;i>0;i--){
          able[i] = able[i-1];
        }
        able[0] = stb;
        this.next_road = (1 + this.next_road)%4;
      }
      else if(r == 1) {
        int stb = able[0];
        for(int i = 0;i<3;i++){
          able[i] = able[i+1];
        }
        able[3] = stb;
        next_road = (-1 + next_road)%4;
      }
    }

    public void flagReset(){
      flag = false;
      flag2 = false;
    }
    void OnMouseDown()
    {
      /*Debug.Log(able[0]);
      Debug.Log(able[1]);
      Debug.Log(able[2]);
      Debug.Log(able[3]);*/
      if(flag){
        flag2 = true;
      }
      flag = true;
      //Vector3 pos = this.transform.position;
      //pos.y = 0.3f;
      //this.transform.position = pos;
  }
}
