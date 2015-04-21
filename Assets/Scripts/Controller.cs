using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float speed;
	public GameObject particleCollisionEffect;
	public GameObject winParticleEffect;
	GameObject particleInstanciated;



	void OnTriggerEnter(Collider other) {

		speed = 0;
		transform.Find ("TheCard/RotationContainer").GetComponent<Rotation> ().speedRotation = 0;
		transform.Find ("Main Camera/SpeedEffect").gameObject.SetActive (false);
		GetComponent<GetMousePosition> ().enabled = false;
		transform.parent = other.transform;


		if (other.tag == "Target") {
			//Win(other.gameObject);
			particleInstanciated = Instantiate (winParticleEffect, transform.position, transform.rotation)as GameObject;
		} else {
			//Lose(other.gameObject);
			particleInstanciated = Instantiate (winParticleEffect, transform.position, transform.rotation)as GameObject;
		}
	}
	
	void Win(GameObject target){
	}
	
	void Lose(GameObject objectHit) {
	}



	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime*speed);

	}
}