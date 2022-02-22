using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
   public float Xangle=5,Yangle=0,Zangle=0;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(Xangle,Yangle,Zangle),Space.Self);
    }
}
