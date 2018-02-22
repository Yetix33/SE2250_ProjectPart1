﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour {
	static public Hero S;
	public float speed = 30;
	public float rollMult = 45;
	public float pitchMult = 15;
	//public float shieldLevel = 1;
	 BoundsCheck idk;


	// Use this for initialization
	void Awake () {
		if (S == null) {
			S = this;
		} else {
			Debug.LogError("Hero.Awake() - attempt to assing two hero" );
		}
		idk = GetComponent<BoundsCheck>();
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
		idk.check();

}
}
