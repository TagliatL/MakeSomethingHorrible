using UnityEngine;
using System.Collections;

public class DestroyAtTime : MonoBehaviour {

	public int lifeTime;
	int time;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		time++;
		if (time > lifeTime)
			Destroy (gameObject);
	}
}
