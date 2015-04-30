using UnityEngine;
using System.Collections;

public class MovingObstacle : Obstacles {

	public Vector3[] wayPoints;
	public int rotationSpeed;
	public int speed;
	public float changeTargetDistance;
	int targetedWayPoint;
	int nextPoint;
	public override void Start () {
		targetedWayPoint = 0;
		nextPoint = 1;
	}
	
	// Update is called once per frame
	public override void Update () {
		transform.Translate(Vector3.forward * Time.deltaTime*speed);
		Quaternion followingPath = Quaternion.LookRotation(wayPoints[targetedWayPoint] - transform.position);
		transform.rotation = Quaternion.Slerp(transform.rotation, followingPath, Time.deltaTime * rotationSpeed);
		Debug.Log (targetedWayPoint);
		if (Vector3.Distance(transform.position, wayPoints[targetedWayPoint]) < changeTargetDistance) {
			targetedWayPoint += nextPoint;	
			if(targetedWayPoint == wayPoints.Length){
				targetedWayPoint = 0;
			}
		}
	}

	void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		for (int i = 0; i < wayPoints.Length; i++) {
			Gizmos.DrawSphere(wayPoints[i], 1);
		}
	}
}
