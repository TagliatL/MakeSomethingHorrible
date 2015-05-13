using UnityEngine;
using System.Collections;

public class MovingObject : MonoBehaviour {

	public Vector3 direction;
	public int speed;
	// Use this for initialization
	
	// Update is called once per frame
	public void Update () {
		transform.Translate(direction * Time.deltaTime * speed);
	}
}
