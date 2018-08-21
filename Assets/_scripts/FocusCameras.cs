using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FocusCameras : MonoBehaviour {

    public Transform focus;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(focus);
        transform.eulerAngles += new Vector3(0, 0, 90.0f);
	}
}
