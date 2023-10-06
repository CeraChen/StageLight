using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLightRot2 : MonoBehaviour
{
    private GameObject mSpotlight;
    private Slider mSlider;

    // Start is called before the first frame update
    void Start()
    {
        mSpotlight = GameObject.Find("BasicDownLight");
        mSlider = GameObject.Find("Canvas/Rotation2").GetComponent<Slider>();
        mSlider.value = mSpotlight.transform.eulerAngles.y;
        mSlider.onValueChanged.AddListener(OnRot2Change);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRot2Change(float value){
        float x = mSpotlight.transform.eulerAngles.x;
        float z = mSpotlight.transform.eulerAngles.z;
        mSpotlight.transform.rotation = Quaternion.Euler(x, value, z);
    }
}