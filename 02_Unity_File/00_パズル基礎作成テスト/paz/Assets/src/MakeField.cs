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
    readonly private int Y = 3;
    readonly private int X = 5;
    public Road[,] field = new Road[3,5];
    public GameObject roadsObj_p;
    public GameObject roadsObj;



    void Awake(){
      makeField();
    }

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      this.a += Time.deltaTime;
      if(this.a >5){
        this.a = 0;
        remakeField();
      }
    }

    public void makeField(){
      roadsObj = Instantiate(roadsObj_p);;
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          int ran = Random.Range(0,4);
          field[y,x] = new Road(x,y,ran);
        }
      }
      for(int y=0;y<Y;y++){
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
      }
    }
    public void remakeField(){
      Destroy(roadsObj);
      this.roadsObj = Instantiate(roadsObj_p);
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          int ran = Random.Range(0,4);
          field[y,x] = new Road(x,y,ran);
        }
      }
      for(int y=0;y<Y;y++){
        for(int x = 0;x<X;x++){
          int ran = Random.Range(0,4);
          field[y,x] = new Road(x,y,ran);
        }
      }
      for(int y=0;y<Y;y++){
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
      }
    }
}
