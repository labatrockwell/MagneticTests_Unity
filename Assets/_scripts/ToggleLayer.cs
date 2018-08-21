using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLayer : MonoBehaviour {

    public Camera basicCamera;

    public Camera[] cams;


    private int defaultLayerMask;
    private int allLayerMask;
    public bool toggle;

    // Use this for initialization
    void Start() {
        
        allLayerMask = basicCamera.cullingMask;

        defaultLayerMask = cams[0].cullingMask;
        Debug.Log("Default: " + defaultLayerMask);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp("t")) {
            if (!toggle) foreach (Camera cam in cams) cam.cullingMask = allLayerMask;
            else foreach (Camera cam in cams) cam.cullingMask = defaultLayerMask;
            toggle = !toggle;
        }
	}
}
