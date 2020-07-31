using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlBar : MonoBehaviour
{

  Slider hp1;
  Slider hp2;
  Slider hp3;
  Slider hp_en1;
  Slider hp_en2;
  Slider hp_en3;

  GameObject time_gage;


    void Start()
    {
      this.hp1 = GameObject.Find("hp1").GetComponent<Slider>();
      this.hp2 = GameObject.Find("hp2").GetComponent<Slider>();
      this.hp3 = GameObject.Find("hp3").GetComponent<Slider>();
      this.hp_en1 = GameObject.Find("hp_en1").GetComponent<Slider>();
      this.hp_en2 = GameObject.Find("hp_en2").GetComponent<Slider>();
      this.hp_en3 = GameObject.Find("hp_en3").GetComponent<Slider>();
      this.time_gage = GameObject.Find("time");

    }

  public void reroadBar(float set1,float set2,float set3,float set4,float set5,float set6){
    hp1.value = set1;
    hp2.value = set2;
    hp3.value = set3;
    hp_en1.value = set4;
    hp_en2.value = set5;
    hp_en3.value = set6;
  }

  public void setTime(float n){
    this.time_gage.GetComponent<Image>().fillAmount = n;
  }
  public void resetTime(){
    this.time_gage.GetComponent<Image>().fillAmount =1;
  }

}
