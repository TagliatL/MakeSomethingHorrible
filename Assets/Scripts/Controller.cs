using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float speed;
	public GameObject target;
	public GameObject winParticleEffect;
	public GameObject LevelManager;
	int collectiblesGot;
	int allCollectiblesOfLevel;
	GameObject particleInstanciated;

	void Start() {
		allCollectiblesOfLevel = GameObject.FindGameObjectsWithTag ("Collectible").Length;
	}
	void Win(){
		LevelManager.SendMessage ("Win");
		target.SetActive (false);
	}
	
	void Lose() {
		LevelManager.SendMessage ("Lose");
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag != "TurretDetection" && other.tag != "Collectible") {
			speed = 0;
			transform.Find ("TheCard/RotationContainer").GetComponent<Rotation> ().speedRotation = 0;
			GetComponent<Collider> ().enabled = false;
			if (GameObject.FindGameObjectWithTag ("SpeedEffect") != null)
				GameObject.FindGameObjectWithTag ("SpeedEffect").SetActive (false);
			
			//destroy the cursor and deactivate the detection of mouse
			Destroy (GetComponent<GetMousePosition> ().cursor.gameObject);
			
			GetComponent<GetMousePosition> ().enabled = false;
			//this is why we put every obstacle in a GO
			transform.parent = other.transform.parent;
			
			if (other.tag == "Target" && collectiblesGot == allCollectiblesOfLevel) {
				particleInstanciated = Instantiate (winParticleEffect, transform.position, transform.rotation)as GameObject;
				Invoke ("Win", 1.0f);
			} else { /*if(other.tag == "Obstacle")*/
				Lose ();
				GameObject.Find ("Main Camera").transform.parent = null;
			}
			//allow the camera to look to the player when he die or win
			GameObject.Find ("Main Camera").GetComponent<LookAtPlayer> ().enabled = true;
			Cursor.visible = true;
		} else if (other.tag == "Collectible") {
			collectiblesGot++;
			if(collectiblesGot == allCollectiblesOfLevel) {
				GetComponent<GetMousePosition>().cursorCanExplode.SetActive(true);
			}
		}
	}

	void OnCollisionEnter(Collision collision) {
		speed = 0;
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		transform.Find ("TheCard/RotationContainer").GetComponent<Rotation> ().speedRotation = 0;
		GetComponent<Collider> ().enabled = false;
		if (GameObject.FindGameObjectWithTag ("SpeedEffect") != null)
			GameObject.FindGameObjectWithTag ("SpeedEffect").SetActive (false);
		
		//destroy the cursor and deactivate the detection of mouse
		Destroy (GetComponent<GetMousePosition> ().cursor.gameObject);
		
		GetComponent<GetMousePosition> ().enabled = false;
		//this is why we put every obstacle in a GO
		transform.parent = collision.transform.parent;
		Lose ();
		GameObject.Find ("Main Camera").transform.parent = null;
		//allow the camera to look to the player when he die or win
		GameObject.Find ("Main Camera").GetComponent<LookAtPlayer> ().enabled = true;
		Cursor.visible = true;
	}

	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime*speed);

	}
}