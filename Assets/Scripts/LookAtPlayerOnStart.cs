using UnityEngine;
using System.Collections;

public class LookAtPlayerOnStart : MonoBehaviour {

	float timer;
	public float stopFollowingPlayer;
	// Use this for initialization

	void Start() {
		timer = 0;
		stopFollowingPlayer = 30;
	}
	void Update(){
		if (timer < stopFollowingPlayer) {
			timer++;
			if(GameObject.FindGameObjectWithTag ("Player") != null)
			transform.LookAt (GameObject.FindGameObjectWithTag ("Player").transform.position);
		}
	}

}
