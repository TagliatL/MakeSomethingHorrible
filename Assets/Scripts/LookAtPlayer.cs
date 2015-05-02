using UnityEngine;
using System.Collections;

public class LookAtPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(GameObject.FindGameObjectWithTag ("Player") != null)
		transform.LookAt (GameObject.FindGameObjectWithTag ("Player").transform.position);
	}
}
