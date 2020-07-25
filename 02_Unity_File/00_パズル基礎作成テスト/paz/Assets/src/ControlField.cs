using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlField : MonoBehaviour
{
    public GameObject Field_m;
    public MakeField makeField;
    GameObject[,] field_ob;
    Road[,] road = new Road[3,5];
    //change の変数
    private bool flag_chang = false;
    private int count_chang = 0;
    int x1=-1,y1=-1,x2=-1,y2=-1;
    // Start is called before the first frame update
    void Start()
    {
      makeField = Field_m.GetComponent<MakeField>();
      field_ob = makeField.field_ob;
      for(int y = 0;y<makeField.Y;y++){
        for(int x = 0;x<makeField.X;x++){
          road[y,x] = field_ob[y,x].GetComponent<Road>();
        }
      }
    }

    // Update is called once per frame
    void Update()
    {
      //field_ob[1,1].transform.Translate(0,0.1f,0);
      check();
    }

    public void roadField(){
      for(int y = 0;y<makeField.Y;y++){
        for(int x = 0;x<makeField.X;x++){
          road[y,x] = field_ob[y,x].GetComponent<Road>();
        }
      }
    }

    void check(){
      int count = 0;
      for(int y = 0;y<makeField.Y;y++){
        for(int x = 0;x<makeField.X;x++){
          if(road[y,x].flag && count==0){
            count = 1;
            x1 = x;
            y1 = y;
          }else if (road[y,x].flag) {
            count = 2;
            x2 = x;
            y2 = y;
          }
        }
      }
      if(count == 2 && ! flag_chang){
        /*Road stb = road[y1,x1];
        road[y1,x1] = road[y2,x2];
        road[y2,x2] = stb;*/

        road[y2,x2].flag = false;
        road[y1,x1].flag = false;

        flag_chang = true;
      }
      if(flag_chang){
        float dx = (x1 - x2);
        float dy = (y1 - y2);
        Debug.Log(dx);
        Debug.Log(dx);
        field_ob[y1,x1].transform.Translate(-dx*0.05f,0,-dy*0.05f,Space.World);
        field_ob[y2,x2].transform.Translate(dx*0.05f,0,dy*0.05f,Space.World);
        count_chang += 1;
        if(count_chang == 20){
          field_ob[y1,x1].transform.position = new Vector3(x2,0,y2);
          field_ob[y2,x2].transform.position = new Vector3(x1,0,y1);

          GameObject stb = field_ob[y1,x1];
          field_ob[y1,x1] = field_ob[y2,x2];
          field_ob[y2,x2] = stb;
          roadField();
          flag_chang = false;
          count_chang = 0;
        }
      }
    }


}
