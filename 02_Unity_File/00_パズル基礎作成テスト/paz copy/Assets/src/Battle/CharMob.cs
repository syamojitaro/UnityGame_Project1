using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMob : CharBase
{
  void Awake()
  {
    setAtk(16);
    setHp(80);
    setHpMax(getHp());
    setDef(7);
    setSp(5);
    setTime(6);
    setRole(1);
    setX(-1);
    setY(0);
  }
}
