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
		if(GameObject.FindGameObjectWithTag("SpeedEffect") != null)
			GameObject.FindGameObjectWithTag("SpeedEffect").SetActive (false);

		//destroy the cursor and deactivate the detection of mouse
		Destroy (GetComponent<GetMousePosition> ().cursor.gameObject);

		GetComponent<GetMousePosition> ().enabled = false;
		//this is why we put every obstacle in a GO
		transform.parent = other.transform.parent;

		if (other.tag == "Target") {
			//Win(other.gameObject);
			particleInstanciated = Instantiate (winParticleEffect, transform.position, transform.rotation)as GameObject;
		} else /*if(other.tag == "Obstacle")*/ {
			//Lose(other.gameObject);
			GameObject.Find("Main Camera").transform.parent = null;
			particleInstanciated = Instantiate (winParticleEffect, transform.position, transform.rotation)as GameObject;
		}
		//allow the camera to look to the player when he die or win
		GameObject.Find("Main Camera").GetComponent<LookAtPlayer>().enabled = true;
		Cursor.visible = true;
	}
	
	void Win(GameObject target){
	}
	
	void Lose(GameObject objectHit) {
	}

	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime*speed);

	}
}