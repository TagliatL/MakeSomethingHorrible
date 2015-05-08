using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {

	public GameObject ExplosionParticle;
	GameObject Particles;
	void OnTriggerEnter(Collider other) {
		Particles = Instantiate (ExplosionParticle, transform.position, Quaternion.identity) as GameObject;
		Particles.GetComponent<ParticleSystem> ().startColor = GetComponent<SpriteRenderer> ().color;
		Destroy (gameObject);
	}
}
