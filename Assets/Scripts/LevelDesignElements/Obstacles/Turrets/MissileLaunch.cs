using UnityEngine;
using System.Collections;

public class MissileLaunch : MonoBehaviour {

	public GameObject missile;
	public int numberOfMissiles;
	public float delayBetween;

	IEnumerator Launch() {
		for(var i =0; i < numberOfMissiles; i++) {
			Instantiate(missile, transform.position, Quaternion.identity);
			if(missile.GetComponent<SmoothLookAt>() !=null)
			{
				missile.GetComponent<SmoothLookAt>().target = GameObject.FindGameObjectWithTag("Player").transform;
			}
			yield return new WaitForSeconds (delayBetween);
		}
	}
	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player") {
			StartCoroutine ("Launch");
		}
	}
}
