using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundsCheck : MonoBehaviour {
	public float radius = 1f;
	public float camWidth;
	public float camHeight;

	void Awake(){
		camHeight = Camera.main.orthographicSize;
		camWidth = camHeight * Camera.main.aspect;
	}



	void OnDrawGizmos(){
		if (!Application.isPlaying)
			return;
		Vector2 bound = new Vector2 (camWidth * 2, camHeight * 2);
		Gizmos.DrawWireCube (Vector2.zero, bound);
	}




	void LateUpdate(){
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

	if (pos.y < -camHeight + radius) {
			pos.y = -camHeight + radius;
		}
		
		transform.position = pos;
	}
}

