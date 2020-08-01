using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Endlesenemy : MonoBehaviour
{
  public GameObject enemy1;
  float span = 0.2f;
  float del = 0;
    // Start is called before the first frame update
    // Update is called once per frame
    void Update()
    {
      this.del += Time.deltaTime;
      if(this.del > this.span){
        this.del = 0;
        GameObject go = Instantiate(enemy1) as GameObject;
        int x = Random.Range(-30,30);
        int z = Random.Range(10,40);
        int sp = Random.Range(0,360);
        go.transform.position = new Vector3(x,40,z);
        go.transform.Rotate(sp,sp,sp);
      }
    }
}
