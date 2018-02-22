using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
	static public Hero S;
	public float speed = 30;
	public float rollMult = 45;
	public float pitchMult = 15;
	//public float shieldLevel = 1;
	public float radius = 3f;
	public float camWidth;
	public float camHeight;



	// Use this for initialization
	void Awake () {
		if (S == null) {
			S = this;
		} else {
			Debug.LogError("Hero.Awake() - attempt to assing two hero" );
		
		
		}
		camHeight = Camera.main.orthographicSize;
		camWidth = camHeight * Camera.main.aspect;
	}

	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Horizontal");
		float y = Input.GetAxis("Vertical");

		Vector3 pos = transform.position;
		pos.x += x * speed * Time.deltaTime;
		pos.y += y * speed * Time.deltaTime;
		transform.position = pos;
		transform.rotation = Quaternion.Euler (0, x * rollMult, 0);


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

	/*void OnDrawGizmos(){
		if (!Application.isPlaying)
			return;
		Vector2 bound = new Vector2 (camWidth * 2, camHeight * 2);
		Gizmos.DrawWireCube (Vector2.zero, bound);
	
	}*/

}
