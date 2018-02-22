using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour {
	public float radius = 1f;
	public float camWidth;
	public float camHeight;
	void Awake(){
		camHeight = Camera.main.orthographicSize+35f;
		camWidth = Camera.main.orthographicSize * Camera.main.aspect;
	}

	// Use this for initialization

	
	// Update is called once per frame
	public void check() {

		Vector3 pos = transform.position;
		if (pos.x > camWidth - radius) {
			pos.x = camWidth - radius;
		}
		if (pos.x < -camWidth + radius) {
			pos.x = -camWidth + radius;
		}
		if (pos.y > camHeight - radius) {
			pos.y = camHeight - radius;
		}
		if (pos.y < 0-radius) {
			pos.y = 0 - radius;
		}
		transform.position = pos;
	}

	/*void OnDrawGizmos(){
		if (!Application.isPlaying)
			return;
		Vector2 bound = new Vector2 (camWidth * 2, camHeight * 2);
		Gizmos.DrawWireCube (Vector2.zero, bound);
	
	}*/

	public bool checkenemy() {
		print ("gang");
		Vector3 pos = transform.position;
		if (pos.x > camWidth - radius) {
			pos.x = camWidth - radius;
			return true;
		}
		if (pos.x < -camWidth + radius) {
			pos.x = -camWidth + radius;
			return true;
		}
		if (pos.y > camHeight - radius) {
			pos.y = camHeight - radius;
			return true;
		}
		if (pos.y < 0-radius) {
			pos.y = 0 - radius;
			return true;
		}
		transform.position = pos;
		return false;
	}



	}

