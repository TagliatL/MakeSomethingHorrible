using UnityEngine;
using System.Collections;

public class BulletForward : MonoBehaviour {

	public float speed;
	public float maxSpeed;
	public float derivation;
	Vector2 derivesXY;
	// Use this for initialization
	
	// Update is called once per frame
	void Start() {
		derivesXY = new Vector2 (Random.Range (-derivation, derivation), Random.Range (-derivation, derivation));
	}

	void Update () {
		if(speed < maxSpeed)
		speed += speed/40;
	
		if (speed <= 10) {
			transform.Translate (Vector3.left * Time.deltaTime * derivesXY [0]);
			transform.Translate (Vector3.up * Time.deltaTime * derivesXY [1]);
		} 
		transform.Translate(Vector3.forward * Time.deltaTime*speed);
	}
}
