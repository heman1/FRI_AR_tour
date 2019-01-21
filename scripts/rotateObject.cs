using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour {

    float[] speeds = new float[] {30.0f, 50.0f, 60.0f, 120.0f, 160.0f};
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        System.Random rand = new System.Random();
        int speed = rand.Next(0,5);
        transform.Rotate(Vector3.up * speeds[speed] * Time.deltaTime, Space.World);
	}
}
