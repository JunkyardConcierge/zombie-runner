using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public bool respawnPlayer = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (respawnPlayer == true) {
			Respawn ();
			respawnPlayer = false;
		}
	}

	public void Respawn(){
		GameObject[] RespawnPoints = GameObject.FindGameObjectsWithTag("Respawn");
		GameObject nextRespawnPoint = RespawnPoints[Random.Range(0, RespawnPoints.Length)];
		Vector3 spawnLocation = nextRespawnPoint.GetComponentInChildren<Transform>().transform.position;
		GameObject.Find ("Player").transform.position = spawnLocation;
		Debug.Log (spawnLocation);
	}
}
