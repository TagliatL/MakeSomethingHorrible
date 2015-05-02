using UnityEngine;
using System.Collections;

public class ExplodeWhenTouchingWalls : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag != "Player" && other.tag != "Bullet" & other.tag != "TurretDetection") {
			Destroy (transform.root.gameObject);
		}
		if (other.tag == "Player") {
			Destroy(transform.parent.GetComponent<SmoothLookAt>());
		}
	}
}
