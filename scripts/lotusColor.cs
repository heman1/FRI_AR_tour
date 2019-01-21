using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class lotusColor : MonoBehaviour {
public Material mobject;
public Color col;
public KeyCode changeColor;
	// Use this for initialization
	void Start () {
    mobject.color = Color.white;
	}
	
	// Update is called once per frame
	void Update () {
        mobject.color = Color.white;
    }
}
