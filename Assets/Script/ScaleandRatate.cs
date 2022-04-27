using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScaleandRatate : MonoBehaviour
{

    // need two sliders to control the obj
    private Slider scaleSlider;
    private Slider rotateSlider;

    //set the range
    public float scaleMinValue;
    public float scaleMaxValue;
    public float rotMinValue;
    public float rotMaxValue;

    public bool applyslider = false;

    void Start()
    {


        // find the slider by name and initialize the max and min value
        scaleSlider = GameObject.Find("ScaleSlider").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

       

        // same thing for rotate slider
        rotateSlider = GameObject.Find("RatateSlider").GetComponent<Slider>();
        rotateSlider.minValue = rotMinValue;
        rotateSlider.maxValue = rotMaxValue;


    }
    // Update is called once per frame

    private void Update()
    {
        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);
        rotateSlider.onValueChanged.AddListener(RotateSliderUpdate);
    }
    //function that scale the size of the object by changing all three coordinates
    void ScaleSliderUpdate(float value)
    {

        if (applyslider)
            transform.localScale = new Vector3(value, value, value);

    }

    //function that  rotate the eobject by changing only y value
    void RotateSliderUpdate(float value)
    {

        if (applyslider)
            transform.localEulerAngles = new Vector3(transform.rotation.x, value, transform.rotation.z);

    }



}
