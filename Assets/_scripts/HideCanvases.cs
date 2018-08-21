using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideCanvases : MonoBehaviour {

    public GameObject[] canvases;
    public bool toggle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp("y")) {
            if (!toggle) foreach (GameObject canvas in canvases) canvas.SetActive(false);
            else foreach (GameObject canvas in canvases) canvas.SetActive(true);
            toggle = !toggle;
        } 

	}
}
