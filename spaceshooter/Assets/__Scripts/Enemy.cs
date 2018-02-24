using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour {

	public float speed = 10f;

	private BoundsCheck boundCheck;

	void Awake(){
		//get BoundsCheck 
		boundCheck = GetComponent<BoundsCheck> ();
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

		//Destroy object if OnScreen is false from boundCheck
		if (boundCheck != null && !boundCheck.isOnScreen) {
				Destroy (gameObject);
		}
	}

	public virtual void Move(){
		//Override default Move 
	}
}
