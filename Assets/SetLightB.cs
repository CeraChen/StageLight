using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLightB : MonoBehaviour
{
    private Light mSpotlight;
    private Slider mSlider;

    // Start is called before the first frame update
    void Start()
    {
        mSpotlight = GameObject.Find("BasicDownLight").GetComponent<Light>();
        mSlider = GameObject.Find("Canvas/ColorB").GetComponent<Slider>();
        mSlider.onValueChanged.AddListener(OnColorBChange);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColorBChange(float value){
        Debug.Log(mSpotlight.color);
        float r = mSpotlight.color.r;
        float g = mSpotlight.color.g;
        mSpotlight.color = new Color(r, g, value/255, 1);
    }
}

