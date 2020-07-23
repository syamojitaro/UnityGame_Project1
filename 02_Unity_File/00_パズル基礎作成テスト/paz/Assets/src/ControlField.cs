using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlField : MonoBehaviour
{
    public GameObject Field_m;
    public MakeField makeField;
    // Start is called before the first frame update
    void Start()
    {
      makeField = Field_m.GetComponent<MakeField>();
      GameObject[,] field_ob = makeField.field_ob;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
