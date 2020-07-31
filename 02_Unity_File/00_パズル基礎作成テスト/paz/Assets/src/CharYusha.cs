using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharYusha : CharBase
{
    // Start is called before the first frame update
    void Awake()
    {
      setAtk(20);
      setHp(100);
      setHpMax(getHp());
      setDef(8);
      setSp(5);
      setTime(7);
      setRole(0);
      setX(-1);
      setY(0);
    }

    public void skill(){

    }
}
