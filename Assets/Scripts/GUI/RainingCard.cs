using UnityEngine;
using System.Collections;

public class RainingCard : MonoBehaviour {

	public GameObject card;
	Vector3 randomSpawnPosition;
	public int delay;
	int timer;
	public GameObject[] cards;
	int cardToSpawn;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer++;
		if (timer > delay) {
			cardToSpawn = Mathf.CeilToInt(Mathf.Round(Random.Range(0, cards.Length)));
			randomSpawnPosition = new Vector3 (transform.position.x + Random.Range (-700, 700), transform.position.y, transform.position.z + Random.Range (-200, 800));
			Instantiate (cards[cardToSpawn].gameObject, randomSpawnPosition, card.transform.rotation);
			timer = 0;
		}
	}
}
