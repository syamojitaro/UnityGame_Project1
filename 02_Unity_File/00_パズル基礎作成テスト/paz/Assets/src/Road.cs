using System.Collections;
using UnityEngine;

public class Road
{
  private int x;
  private int y;
  private int type;//道路のたいぷ 0:まっすぐ 1:曲がる　2:t字 3:cros
  private int spin;//回転してるか0:デフォルト　そこから右回転で+1
  private int[] able;//そこが通れるか[l,u,r,d]
  private int next_road;//0:l,1:u,2:r,3:d

  public Road(int x,int y,int type){
    this.x = x;
    this.y = y;
    this.type = type;
    this.spin = Random.Range(0,4);
    if(type == 0){
      this.able = new int[4]{1,0,1,0};
      this.next_road = 0;
    }else if(type == 1){
      this.able = new int[4]{1,0,0,1};
      this.next_road = 0;
    }else if(type == 2){
      this.able = new int[4]{1,0,0,1};
      this.next_road = 1;
    }else if(type == 3){
      this.able = new int[4]{1,1,0,1};
      this.next_road = 2;
    }
    for(int ss= 0;ss<spin;ss++){
        int stb = able[3];
        for(int i = 3;i>0;i--){
          this.able[i] = this.able[i-1];
        }
        this.able[0] = stb;
        this.next_road = (1 + this.next_road)%4;
    }
  }

    public void setX(int x){
      this.x = x;
    }
    public void setY(int y){
      this.y = y;
    }
    public int getX(){
      return this.x;
    }
    public int getY(){
      return this.y;
    }
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
    public void spinLoad(int r){//0:右回転　1:左回転
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


}
