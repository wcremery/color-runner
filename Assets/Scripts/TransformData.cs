using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TransformData 
{
    public string name;
    public Vector3 position;
    public Quaternion rotation;
    public Vector3 scale;

    public TransformData(Vector3 p, Quaternion r, Vector3 s){
      position = p;
      rotation = r;
      scale = s;
    }
}
