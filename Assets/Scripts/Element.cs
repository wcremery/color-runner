using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Element : MonoBehaviour
{
    public TransformData GetTransformData()
    {
        TransformData transformData = new TransformData(
           transform.position,
           transform.rotation,
           transform.localScale
          );
        return transformData;
    }

    public void SetTransformData(TransformData transformData)
    {
        transform.position = transformData.position;
        transform.rotation = transformData.rotation;
        transform.localScale = transformData.scale;
    }
}
