using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustSlider : MonoBehaviour {

    Slider slider;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) slider.value += slider.minValue / 20.0f;
        if (Input.GetKey(KeyCode.RightArrow)) slider.value -= slider.minValue / 20.0f;
	}
}
