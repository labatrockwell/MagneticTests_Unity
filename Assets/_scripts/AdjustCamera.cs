using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdjustCamera : MonoBehaviour {

    public Transform lookTarget;
    private Vector3 origin;
    Camera[] cams;

	// Use this for initialization
	void Start () {
        origin = lookTarget.position;
        cams = GetComponentsInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp(KeyCode.UpArrow)) {
            transform.position += new Vector3(0.0f, 0.1f, 0.0f);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            transform.position -= new Vector3(0.0f, 0.1f, 0.0f);
        }

    }

    public void SetFoV(Slider _s){
        foreach(Camera c in cams){
            c.fieldOfView = _s.value;
        }
    }

    void LateUpdate() {
        //transform.LookAt(origin);
    }
}
