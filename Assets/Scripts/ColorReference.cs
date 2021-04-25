using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ColorReference
{
    public bool UseConstant;
    public ColorVariable Variable ;
    public ColorType.ColorList ConstantValue;
    public ColorType.ColorList Value
    {
        get { return UseConstant ? ConstantValue : Variable.value; }
    }
}
