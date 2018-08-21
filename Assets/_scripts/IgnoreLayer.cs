using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class IgnoreLayer : MonoBehaviour {
    private float m_Rnd;
    [Range(0.0f,10.0f)]
    public float multiplier;
    // Use this for initialization
    void Start () {
        m_Rnd = Random.value * 100;
    }
	
	// Update is called once per frame
	void Update () {
        //m_Light.intensity = 2 * Mathf.PerlinNoise(m_Rnd + Time.time, m_Rnd + 1 + Time.time * 1);
        float x = Mathf.PerlinNoise(m_Rnd + 0 + Time.time * 2, m_Rnd + 1 + Time.time * 2) - 0.5f;
        float y = Mathf.PerlinNoise(m_Rnd + 2 + Time.time * 2, m_Rnd + 3 + Time.time * 2) - 0.5f;
        float z = Mathf.PerlinNoise(m_Rnd + 4 + Time.time * 2, m_Rnd + 5 + Time.time * 2) - 0.5f;
        transform.localPosition = Vector3.up + new Vector3(x, y, z) * 1;

    }
}
