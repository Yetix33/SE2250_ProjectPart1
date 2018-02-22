using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	public float speed = 10f;
	BoundsCheck idk;

	void Awake(){
		idk = GetComponent<BoundsCheck> ();
	}

	public Vector3 pos{
		get{ 
			return(this.transform.position);
		}
		set{ 
			this.transform.position = value;
		}

	}

	// Update is called once per frame
	void Update () {
		Move();
		if (!(idk.checkenemy())) {
			print("yikes");
			//gameObject.SetActive (false);
		}
			
	}
	public virtual void Move(){
		//idfkwtfdywfm
	}
}
