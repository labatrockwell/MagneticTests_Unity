using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustFocalPoint : MonoBehaviour {



	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void SetDistance(Slider _s){
        transform.localPosition = new Vector3(_s.value, 0.0f, 0.0f);
    }

}
