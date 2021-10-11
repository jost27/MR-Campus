using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class animbyslide : MonoBehaviour
{
   
    public Animator animator;
    //public Slider slider; //normal ui
     public PinchSlider slider;//hololens

    [Tooltip("active and desactvie the ui info into the motor")]
    public GameObject UIManager;
   
    private void Update() {
        animationbyslide();
    }
    public void animationbyslide(){
        float pivot= slider.SliderValue;
        //pivot=Mathf.Clamp(0,1,pivot);
        animator.SetFloat("blend",pivot);
        //Debug.Log(pivot);
        if(pivot<0.5f) UIManager.SetActive(false); else UIManager.SetActive(true);

    }
    public void SalirApp(){
        Application.Quit();
        #if UNITY_EDITOR
            EditorApplication.isPaused = true;
        #endif


    }
}
public static class Orientation{
    public static bool isVertical;

}