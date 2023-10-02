using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetLightRot1 : MonoBehaviour
{
    private GameObject mSpotlight;
    private Slider mSlider;

    // Start is called before the first frame update
    void Start()
    {
        mSpotlight = GameObject.Find("BasicDownLight");
        mSlider = GameObject.Find("Canvas/Rotation1").GetComponent<Slider>();
        mSlider.onValueChanged.AddListener(OnRot1Change);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnRot1Change(float value){
        float y = mSpotlight.transform.localEulerAngles.y;
        float z = mSpotlight.transform.localEulerAngles.z;
        mSpotlight.transform.localEulerAngles = new Vector3(value, y, z);
    }
}