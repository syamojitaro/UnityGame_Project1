using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlChar : MonoBehaviour
{
  //もろもろ
  public GameObject controlField;
  public ControlField control_field;
  public GameObject controlBar;
  public ControlBar control_bar;
  GameObject[,] field_ob;
  Road[,] road = new Road[3,5];
  int Y = 3;
  int X = 5;

  int count = 10;
  int count_en = 0;
  int count_turn = 0;
  int time_all;
  // turn
  public GameObject controlTrun;
  public ControlTrun control_turn;

  public GameObject makeChara;
  public MakeChar make_chara;
  public GameObject[] chara_ob;
  public CharBase[] charas;
  public GameObject[] enemy_ob;
  public CharBase[] enemies;
  public GameObject yumiya;
  GameObject[] yumiyas = new GameObject[3];

  public AudioClip atk_sound_me;
  public AudioClip atk_sound_en;
  AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
      control_turn = controlTrun.GetComponent<ControlTrun>();
      control_bar = controlBar.GetComponent<ControlBar>();
      make_chara = makeChara.GetComponent<MakeChar>();
      chara_ob = make_chara.chara_ob;
      charas = make_chara.charas;
      enemy_ob = make_chara.enemy_ob;
      enemies = make_chara.enemies;
      time_all = (charas[0].getTime() + charas[1].getTime() + charas[2].getTime())*40;
      audioSource = GetComponent<AudioSource>();
    }
    public void roadField(){
      control_field = controlField.GetComponent<ControlField>();
      this.field_ob = control_field.field_ob;
      for(int y = 0;y<Y;y++){
        for(int x = 0;x<X;x++){
          road[y,x] = this.field_ob[y,x].GetComponent<Road>();
        }
      }
    }

    // Update is called once per frame
    void Update()
    {
      if(!(charas[0].life || charas[1].life || charas[2].life)){
        SceneManager.LoadScene("GameOver");
      }
      if(control_turn.getTurn() == 2){
        atkEn();
      }
      else if(control_turn.getTurn() == 1){
        count ++;
        if(count == 20){
          count = 0;
        }
        for(int i = 0;i<3;i++){
          if(charas[i].atk_flag){
            atkMe(chara_ob[i],charas[i]);
          }
          if(charas[i].idou && charas[i].life){
            moveMe(chara_ob[i],charas[i]);
          }
        }
        if (!(charas[0].idou || charas[0].atk_flag || charas[1].idou || charas[1].atk_flag || charas[2].idou || charas[2].atk_flag)){
          control_turn.changeTurn();
        }
      }
      else if(control_turn.getTurn() == 0){
        count_turn++;
        control_bar.setTime(1-(float)count_turn/(float)time_all);
        if(count_turn == time_all){
          count_turn = 0;
          control_turn.changeTurn();
        }
      }
    }

    public void moveMe(GameObject obj,CharBase src){
      if(count == 0){
        switch(src.next_rode){
          case 2:
          src.setX(src.getX()+1);
          break;
          case 3:
          src.setY(src.getY()-1);
          break;
          case 0:
          src.setX(src.getX()-1);
          break;
          case 1:
          src.setY(src.getY()+1);
          break;
        }
        if(src.getX()<0 || src.getY()<0 || src.getY()>=3){
          src.idou = false;
          obj.transform.position = new Vector3(-1,0.5f,src.getMyNumber());
          src.setX(-1);
          src.setY(src.getMyNumber());
        }else if(src.getX()>=5){
          src.idou = false;
          src.atk_flag = true;
          src.setX(-1);
        }else{
          int[] able = road[src.getY(),src.getX()].getAble();
          if(able[(src.next_rode+2)%4] == 0){
            src.idou = false;
            obj.transform.position = new Vector3(-1,0.5f,src.getMyNumber());
            src.setX(-1);
            src.setY(src.getMyNumber());
          }
        }
      }
      if(count == 10){
        src.next_rode = road[src.getY(),src.getX()].getNext((src.next_rode+2)%4);
      }

      switch(src.next_rode){
        case 2:
        obj.transform.Translate(0.05f,0,0,Space.World);
        break;
        case 3:
        obj.transform.Translate(0,0,-0.05f,Space.World);
        break;
        case 0:
        obj.transform.Translate(-0.05f,0,0,Space.World);
        break;
        case 1:
        obj.transform.Translate(0,0,0.05f,Space.World);
        break;
      }
    }
    public void atkMe(GameObject obj,CharBase src){
      int number = src.getY();
      if(enemies[number].life){
        if(count == 0){
          audioSource.PlayOneShot(atk_sound_me);
          enemies[number].damage(src.getAtk());
          enemies[number].checkLife();
          src.atk_flag = false;
          obj.transform.position = new Vector3(-1,0.5f,src.getMyNumber());
          src.setY(src.getMyNumber());
          control_bar.reroadBar(charas[0].getHpMaxRate(),charas[1].getHpMaxRate(),charas[2].getHpMaxRate(),enemies[0].getHpMaxRate(),enemies[1].getHpMaxRate(),enemies[2].getHpMaxRate());
        }
        obj.transform.Rotate(0,0,18);
      }else if(count == 0){
        obj.transform.position = new Vector3(-1,0.5f,src.getMyNumber());
        src.setY(src.getMyNumber());
      }
    }

  public void atkEn(){
    count_en ++;
    if(count_en == 30){
      for(int i = 0;i<3;i++){
        if(enemies[i].life){
          audioSource.PlayOneShot(atk_sound_en);
          yumiyas[i] = Instantiate(yumiya);
          yumiyas[i].transform.position = new Vector3(enemies[i].getX(),0.5f,enemies[i].getY());
        }
      }
    }else if(count_en >= 30){
      for(int i = 0;i<3;i++){
        if(enemies[i].life){
          yumiyas[i].transform.Translate(-0.3f,0,0,Space.World);
        }
      }
      if(count_en == 60){
        for(int i = 0;i<3;i++){
          if(enemies[i].life && charas[i].life){
            charas[i].damage(enemies[i].getAtk());
            charas[i].checkLife();
          }
        }
        control_bar.reroadBar(charas[0].getHpMaxRate(),charas[1].getHpMaxRate(),charas[2].getHpMaxRate(),enemies[0].getHpMaxRate(),enemies[1].getHpMaxRate(),enemies[2].getHpMaxRate());
      }
      if(count_en == 100){
        count_en = 0;
        control_turn.changeTurn();
      }
    }
  }


    public void flagReset(){
      for(int i = 0;i<3;i++){
        charas[i].flagReset();
        charas[i].next_rode = 2;
        count = 10;
      }
    }
}
