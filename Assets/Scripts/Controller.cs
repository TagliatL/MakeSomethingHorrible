using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float speed;
	public GameObject target;
	public GameObject winParticleEffect;
	public GameObject LevelManager;
	GameObject particleInstanciated;

	void Win(){
		LevelManager.SendMessage ("Win");
		target.SetActive (false);
	}
	
	void Lose() {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag != "TurretDetection") {
			speed = 0;
			transform.Find ("TheCard/RotationContainer").GetComponent<Rotation> ().speedRotation = 0;
			GetComponent<Collider>().enabled = false;
			if(GameObject.FindGameObjectWithTag("SpeedEffect") != null)
				GameObject.FindGameObjectWithTag("SpeedEffect").SetActive (false);
			
			//destroy the cursor and deactivate the detection of mouse
			Destroy (GetComponent<GetMousePosition> ().cursor.gameObject);
			
			GetComponent<GetMousePosition> ().enabled = false;
			//this is why we put every obstacle in a GO
			transform.parent = other.transform.parent;
			
			if (other.tag == "Target") {
				particleInstanciated = Instantiate (winParticleEffect, transform.position, transform.rotation)as GameObject;
				Invoke("Win",1.0f);
			}else /*if(other.tag == "Obstacle")*/ {
				Lose();
				GameObject.Find("Main Camera").transform.parent = null;
			}
			//allow the camera to look to the player when he die or win
			GameObject.Find("Main Camera").GetComponent<LookAtPlayer>().enabled = true;
			Cursor.visible = true;
		}
	}

	void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime*speed);

	}
}