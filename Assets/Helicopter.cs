using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helicopter : MonoBehaviour {

	public AudioClip callSound;
	private bool called = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("CallHeli") && !called) {
			called = true;
			print ("Helicopter called");
		} 
	}
}
