using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLayoutSwitch : MonoBehaviour {

    Camera[] cams;
    List<Rect> viewPortRects;

	// Use this for initialization
	void Start () {
        
        viewPortRects = new List<Rect>();
        cams = GetComponentsInChildren<Camera>();
        foreach(Camera cam in cams){
            Rect r = cam.rect;
            viewPortRects.Add(r);
        }
        ReverseCameraOrder();

	}

    private void Update()
    {
        if (Input.GetKeyUp("q")){

            ReverseCameraOrder();
        }
    }

    public void ReverseCameraOrder(){

        viewPortRects.Reverse();
        for (int i = 0; i < cams.Length; i++){
            cams[i].rect = viewPortRects[i];
        }

    }
}
