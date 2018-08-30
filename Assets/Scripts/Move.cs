using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    // Use this for initialization
    private float m_speed = 0.1f;
    public float A = -0.038f;

    public float DelayTime = 2;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        DelayTime -= Time.deltaTime;
        if(transform.position.y < 12 && DelayTime < 0) {
            //Debug.Log(m_speed);
            // v = v0 + at
            m_speed = m_speed + A * Time.deltaTime;
            transform.position += Vector3.up * m_speed;
            if (m_speed < 0.01)
            {
                m_speed = 0.01f;
            }
        }
	}
}
