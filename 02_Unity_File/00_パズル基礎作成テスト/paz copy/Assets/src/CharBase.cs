using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharBase : MonoBehaviour
{
  private int atk;
  private int hp;
  private int hp_max;
  private int dfe;
  private int sp;
  private int time;
  private int role;
  private int my_number;

  public bool idou = true;
  public bool atk_flag = false;
  public int next_rode  =2;



  public bool life = true;

  private int x;
  private int y;

  public int getX(){
    return x;
  }
  public int getY(){
    return y;
  }
  public void setX(int x){
    this.x = x;
  }
  public void setY(int y){
    this.y = y;
  }

  public int getMyNumber(){
    return my_number;
  }
  public void setMyNumber(int my_number){
    this.my_number = my_number;
  }
  public int getAtk(){
    return atk;
  }
  public void setAtk(int set){
    this.atk = set;
  }
  public int getHp(){
    return hp;
  }
  public void setHp(int set){
    this.hp = set;
  }
  public float getHpMaxRate(){
    float rate = (float)hp/(float)hp_max;
    return rate;
  }
  public void setHpMax(int set){
    this.hp_max = set;
  }
  public int getDfe(){
    return dfe;
  }
  public void setDef(int set){
    this.dfe = set;
  }
  public int getSp(){
    return sp;
  }
  public void setSp(int set){
    this.sp = set;
  }
  public int getTime(){
    return time;
  }
  public void setTime(int set){
    this.time = set;
  }
  public int getRole(){
    return role;
  }
  public void setRole(int set){
    this.role = set;
  }

  public void skill(){
  }

  public void damage(int en_atk){
    hp -= en_atk;
    GetComponent<ParticleSystem>().Play();
    if(hp<=0){
      life = false;
      hp = 0;
    }
  }

  public void flagReset(){
    idou = true;
    atk_flag = false;
  }

  public void checkLife(){
    if(!life){
      transform.Translate(0,0.6f,0,Space.World);
      transform.Rotate(0,0,180);
    }
  }
}
