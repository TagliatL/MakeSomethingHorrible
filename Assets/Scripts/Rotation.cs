using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public int speedRotation;
	// Use this for initialization
	void Start () {
	
	}
	
	void Update() {
		transform.Rotate(Vector3.up * Time.deltaTime*speedRotation*100);
	}
}
