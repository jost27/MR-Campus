using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uinotcontroller : MonoBehaviour
{
    
    public GameObject targert;
    public Vector3 offsetpos;
    GameObject camera;
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        camera=GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        trackerposition();
        trackercamera();
    }

    void trackerposition(){
        pos.x=targert.transform.position.x+offsetpos.x;
        pos.y=targert.transform.position.y+offsetpos.y;
        pos.z=targert.transform.position.z+offsetpos.z;

        transform.position=pos;
    }

    void trackercamera(){
        transform.LookAt(camera.transform,Vector3.forward);

    }
}
