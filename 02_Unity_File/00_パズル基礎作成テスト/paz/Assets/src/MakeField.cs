using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeField : MonoBehaviour
{
  float a = 0;
    //kokopurehabu
    public GameObject st;
    public GameObject r;
    public GameObject t;
    public GameObject cro;
    Road[,] road = new Road[3,5];
    readonly public int Y = 3;
    readonly public int X = 5;
    public GameObject[,] field_ob = new GameObject[3,5];
    public GameObject roadsObj_p;
    public GameObject roadsObj;

    public GameObject control_ob;
    public ControlField control_scr;



    void Awake(){
      makeField();
      control_scr = control_ob.GetComponent<ControlField>();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      this.a += Time.deltaTime;
      if(this.a >30){
        this.a = 0;
        remakeField();
      }
    }

    public void makeField(){
      roadsObj = Instantiate(roadsObj_p);;
      /*for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          GameObject g;
          if(field[y,x].getType() == 0){
            g = Instantiate(st, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }else if(field[y,x].getType() == 1){
            g = Instantiate(r, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }else if(field[y,x].getType() == 2){
            g = Instantiate(t, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }else if(field[y,x].getType() == 3){
            g = Instantiate(cro, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }
        }
      }*/
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          int ran = Random.Range(0,4);
          if(ran == 0){
            field_ob[y,x] = Instantiate(st, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }else if(ran == 1){
            field_ob[y,x] = Instantiate(r, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }else if(ran == 2){
            field_ob[y,x] = Instantiate(t, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }else if(ran == 3){
            field_ob[y,x] = Instantiate(cro, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }
          field_ob[y,x].transform.position = new Vector3(x,0,y);
          field_ob[y,x].transform.Rotate(0,road[y,x].getDeg(),0);
        }
    }
  }
    public void remakeField(){
      Destroy(roadsObj);
      this.roadsObj = Instantiate(roadsObj_p);
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          int ran = Random.Range(0,4);
          if(ran == 0){
            field_ob[y,x] = Instantiate(st, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }else if(ran == 1){
            field_ob[y,x] = Instantiate(r, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }else if(ran == 2){
            field_ob[y,x] = Instantiate(t, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }else if(ran == 3){
            field_ob[y,x] = Instantiate(cro, roadsObj.transform);
            road[y,x] = field_ob[y,x].GetComponent<Road>();
          }
          field_ob[y,x].transform.position = new Vector3(x,0,y);
          field_ob[y,x].transform.Rotate(0,road[y,x].getDeg(),0);
        }
    }
      /*for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          GameObject g;
          if(field[y,x].getType() == 0){
            g = Instantiate(st, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }else if(field[y,x].getType() == 1){
            g = Instantiate(r, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }else if(field[y,x].getType() == 2){
            g = Instantiate(t, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }else if(field[y,x].getType() == 3){
            g = Instantiate(cro, roadsObj.transform);
            g.transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
            g.transform.Rotate(0,field[y,x].getDeg(),0);
          }
        }
      }*/
      /*for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          if(field[y,x].getType() == 0){
            field_ob[y,x] = Instantiate(st, roadsObj.transform);
          }else if(field[y,x].getType() == 1){
            field_ob[y,x] = Instantiate(r, roadsObj.transform);
          }else if(field[y,x].getType() == 2){
            field_ob[y,x] = Instantiate(t, roadsObj.transform);
          }else if(field[y,x].getType() == 3){
            field_ob[y,x] = Instantiate(cro, roadsObj.transform);
          }
          field_ob[y,x].transform.position = new Vector3(field[y,x].getX(),0,field[y,x].getY());
          field_ob[y,x].transform.Rotate(0,field[y,x].getDeg(),0);
        }
    }*/
    control_scr.roadField();
    }
}
