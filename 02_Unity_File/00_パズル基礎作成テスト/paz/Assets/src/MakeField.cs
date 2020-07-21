using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeField : MonoBehaviour
{
    public GameObject st;
    public GameObject r;
    public GameObject t;
    public GameObject cro;
    readonly private int Y = 3;
    readonly private int X = 5;
    Road[,] field = new Road[3,5];
    GameObject[,] field_ob = new GameObject[3,5];

    void Start()
    {
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          int ran = Random.Range(0,4);
          field[y,x] = new Road(x,y,ran);
        }
      }
      makeField();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void makeField(){
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          if(field[y,x].getType() == 0){
            field_ob[y,x] = Instantiate(st) as GameObject;
          }else if(field[y,x].getType() == 1){
            field_ob[y,x] = Instantiate(r) as GameObject;
          }else if(field[y,x].getType() == 2){
            field_ob[y,x] = Instantiate(t) as GameObject;
          }else if(field[y,x].getType() == 3){
            field_ob[y,x] = Instantiate(cro) as GameObject;
          }
          field_ob[y,x].transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
          field_ob[y,x].transform.Rotate(0,field[y,x].getDeg(),0);
        }
      }
    }
}
