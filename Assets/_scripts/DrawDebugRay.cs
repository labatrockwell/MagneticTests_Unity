using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawDebugRay : MonoBehaviour {

    public Color rayColor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    [ExecuteInEditMode]
	void Update () {
        Debug.DrawRay(transform.position, transform.forward, rayColor);
	}
}
