using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLightR : MonoBehaviour
{
    private Light mSpotlight;
    private Slider mSlider;

    // Start is called before the first frame update
    void Start()
    {
        mSpotlight = GameObject.Find("BasicDownLight").GetComponent<Light>();
        mSlider = GameObject.Find("Canvas/ColorR").GetComponent<Slider>();
        mSlider.onValueChanged.AddListener(OnColorRChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColorRChange(float value){
        float g = mSpotlight.color.g;
        float b = mSpotlight.color.b;
        mSpotlight.color = new Color(value/255, g, b, 1);
    }
}
