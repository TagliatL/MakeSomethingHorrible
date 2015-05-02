using UnityEngine;
using System.Collections;

public class ExplodeWhenTouchingWalls : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if (other.tag != "Player") {
			Destroy(transform.root.gameObject);
		}
	}
}
