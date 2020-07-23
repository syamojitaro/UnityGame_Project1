using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road_cro : Road
{
  void Awake(){
  this.type = 3;
  this.spin = Random.Range(0,4);
  this.able = new int[4]{1,1,1,1};
  this.next_road = 1;
  for(int ss= 0;ss<spin;ss++){
      int stb = able[3];
      for(int i = 3;i>0;i--){
        this.able[i] = this.able[i-1];
      }
      this.able[0] = stb;
      next_road = (1 + next_road)%4;
    }
  }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
