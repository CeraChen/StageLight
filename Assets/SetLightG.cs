using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLightG : MonoBehaviour
{
    private Light mSpotlight;
    private Slider mSlider;

    // Start is called before the first frame update
    void Start()
    {
        mSpotlight = GameObject.Find("BasicDownLight").GetComponent<Light>();
        mSlider = GameObject.Find("Canvas/ColorG").GetComponent<Slider>();
        mSlider.onValueChanged.AddListener(OnColorGChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColorGChange(float value){
        float r = mSpotlight.color.r;
        float b = mSpotlight.color.b;
        mSpotlight.color = new Color(r, value/255, b, 1);
    }
}

