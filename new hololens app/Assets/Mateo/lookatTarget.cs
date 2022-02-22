using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatTarget : MonoBehaviour
{
    [SerializeField]
    Vector3 position;
    GameObject maincamera;
    // Start is called before the first frame update
    void Start()
    {
        maincamera = GameObject.FindGameObjectWithTag("MainCamera");
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(maincamera.transform, position);
    }
}
