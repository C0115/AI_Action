using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	const float MoveDistance = 0.2f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Animator anim = GetComponent<Animator> ();

		if (Input.GetKey (KeyCode.RightArrow)) {
			anim.SetBool ("OnRightKey", true);
			anim.SetBool ("RightStop", false);
			transform.position += transform.right * MoveDistance;
		} else {
			anim.SetBool ("OnRightKey", false);
			anim.SetBool ("RightStop", true);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			anim.SetBool ("OnLeftKey", true);
			anim.SetBool ("LeftStop", false);
			transform.position -= transform.right * MoveDistance;
		} else {
			anim.SetBool ("OnLeftKey", false);
			anim.SetBool ("LeftStop", true);
		}
	}
}
