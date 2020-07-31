using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharEnemy1 : CharBase
{
  void Awake()
  {
    setAtk(10);
    setHp(100);
    setHpMax(getHp());
    setDef(8);
    setSp(5);
    setTime(7);
    setRole(-1);
    setX(6);
    setY(0);
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
