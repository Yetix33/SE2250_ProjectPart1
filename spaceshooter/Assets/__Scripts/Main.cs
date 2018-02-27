using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour {

	public GameObject[] enemies;
	public float enemySpawns = 0.5f;
	public float enemyDefaultSpacing = 1.5f;

	private BoundsCheck boundCheck;

	void Awake(){
		boundCheck = GetComponent<BoundsCheck> ();

		//Call Spawn function (in 2 seconds)
		Invoke ("Spawn", 1f / enemySpawns);
	}
		

	public void Spawn(){

		//Randomly pick an enemey type from list of enemies
		int rng = Random.Range (0, enemies.Length);
		print (rng);
		//instantiate it 
		GameObject enemy = Instantiate<GameObject> (enemies [rng]);

		float enemySpacing = enemyDefaultSpacing;
		//Random X point:
		if (enemy.GetComponent<BoundsCheck> () != null) {
			enemySpacing = Mathf.Abs (enemy.GetComponent<BoundsCheck> ().radius);
		}

		Vector3 pos = Vector3.zero;

		float xMin = -boundCheck.camWidth + enemySpacing;
		float xMax = boundCheck.camWidth - enemySpacing;

		pos.x = Random.Range (xMin, xMax);
		pos.y = boundCheck.camHeight + enemySpacing;
		enemy.transform.position = pos;

		//RECALL FUNCTION (keeps going)

		Invoke ("Spawn", 1f / enemySpawns);


	}

}
