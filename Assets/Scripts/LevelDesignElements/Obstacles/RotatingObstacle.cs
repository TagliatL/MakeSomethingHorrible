using UnityEngine;
using System.Collections;

public class RotatingObstacle : Obstacles {

	public Vector3 rotation;
	public int speed;
	// Use this for initialization
	public override void Start () {
	
	}
	
	// Update is called once per frame
	public override void Update () {
		transform.Rotate(rotation * Time.deltaTime*speed);
	}
}
