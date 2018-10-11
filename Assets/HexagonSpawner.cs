using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HexagonSpawner : MonoBehaviour {

	public GameObject hexagonPrefab;
	public float spawnRate = 1f;

	private float nextTimeToSpawn = 0;

	
	// Update is called once per frame
	void Update () {
		
		if (Time.time > nextTimeToSpawn)
		{
			Instantiate(hexagonPrefab, Vector3.zero, Quaternion.identity);
			nextTimeToSpawn = Time.time + 1 / spawnRate;
		}
	}
}
