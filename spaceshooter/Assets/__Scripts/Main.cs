using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject Enemy_0;
	public GameObject Enemy_1;

	// Use this for initialization
	void Start () {
		System.Random rand = new System.Random();

		//Spawn Points
		float topSpawnPoint = Camera.main.orthographicSize;
		float xSpawnPoint = topSpawnPoint * Camera.main.aspect;

		//random horizontal spawn point
		float xSpawn = rand.Next ((int)-xSpawnPoint+5, (int)xSpawnPoint-5);
		float xSpawn2 = rand.Next ((int)-xSpawnPoint+5, (int)xSpawnPoint-5);

		//Positions
		Vector2 pos = new Vector2 (xSpawn,topSpawnPoint);
		Vector2 pos2 = new Vector2 (xSpawn2, topSpawnPoint); 

		//Instantiate
		Instantiate (Enemy_0, pos, Quaternion.identity);
		Instantiate (Enemy_1, pos2, Quaternion.identity);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
