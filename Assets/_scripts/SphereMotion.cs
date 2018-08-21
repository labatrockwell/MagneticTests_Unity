using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class SphereMotion : MonoBehaviour
{
    private float m_Rnd;
    [Range(0.0f, 10.0f)]
    public float multiplier;
    public int mode = 0;
    Vector3 origPos;
    public bool isEnabled;
    public GameObject particles;

    // Use this for initialization
    void Start()
    {
        m_Rnd = Random.value * 100;
        origPos = transform.localPosition;
        if (!isEnabled) {
            gameObject.GetComponent<Renderer>().enabled = false;
            particles.SetActive(false);
        } 
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Space)) {
            isEnabled = !isEnabled;
            if (isEnabled)
            {
                gameObject.GetComponent<Renderer>().enabled = true;
                particles.SetActive(true);
            }
            else {
                gameObject.GetComponent<Renderer>().enabled = false;
                particles.SetActive(false);
            } 
        }

        if (Input.GetKeyUp("r")) {
            mode++;
            if (mode == 1) transform.localPosition = origPos;
            if (mode > 2) mode = 0;
        }

        multiplier += Input.GetAxis("Mouse ScrollWheel");

        if (mode == 0) {
            //m_Light.intensity = 2 * Mathf.PerlinNoise(m_Rnd + Time.time, m_Rnd + 1 + Time.time * 1);
            float x = Mathf.PerlinNoise(m_Rnd + 0 + Time.time * multiplier, m_Rnd + 1 + Time.time * multiplier) - multiplier;
            float y = Mathf.PerlinNoise(m_Rnd + 2 + Time.time * multiplier, m_Rnd + 3 + Time.time * multiplier) - multiplier / 3;
            float z = Mathf.PerlinNoise(m_Rnd + 4 + Time.time * multiplier, m_Rnd + 5 + Time.time * multiplier) - multiplier/3;
            transform.localPosition = new Vector3(x, y, z) * 1;
        }
        if (mode == 1) {
            float x = (-0.66f*(0.5f*Mathf.Sin(Time.time)+0.5f));
            transform.position = new Vector3(x, origPos.y, origPos.z);
            //float s = x * 0.66f + 0.15f;
            //transform.localScale = new Vector3(s, s, s);
        }
    }
}