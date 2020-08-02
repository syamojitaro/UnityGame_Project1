using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeChar : MonoBehaviour
{
  public GameObject yusha;
  public GameObject mob1;
  public GameObject mob2;

  public GameObject enemy;
  public GameObject dai;

  public CharBase[] charas = new CharBase[3];
  public CharBase[] enemies = new CharBase[3];
  public GameObject[] chara_ob = new GameObject[3];
  public GameObject[] enemy_ob = new GameObject[3];

  int Y = 5;
    // Start is called before the first frame update
    void Awake(){
      chara_ob[0] = Instantiate(yusha);
      charas[0] = chara_ob[0].GetComponent<CharBase>();
      chara_ob[1] = Instantiate(mob1);
      charas[1] = chara_ob[1].GetComponent<CharBase>();
      chara_ob[2] = Instantiate(mob2);
      charas[2] = chara_ob[2].GetComponent<CharBase>();

      enemy_ob[0] = Instantiate(enemy);
      enemies[0] = enemy_ob[0].GetComponent<CharBase>();
      enemy_ob[1] = Instantiate(enemy);
      enemies[1] = enemy_ob[1].GetComponent<CharBase>();
      enemy_ob[2] = Instantiate(enemy);
      enemies[2] = enemy_ob[2].GetComponent<CharBase>();
    }
    void Start(){
      for(int i = 0;i<3;i++){
        GameObject g;
        charas[i].transform.position = new Vector3(-1,0.5f,i);
        charas[i].setY(i);
        charas[i].setMyNumber(i);
        g = Instantiate(dai);
        g.transform.position = new Vector3(-1,0,i);
        enemies[i].transform.position = new Vector3(Y,0.3f,i);
        enemies[i].setY(i);
        enemies[i].setMyNumber(i);
        g = Instantiate(dai);
        g.transform.position = new Vector3(Y,0,i);
      }
    }
}
