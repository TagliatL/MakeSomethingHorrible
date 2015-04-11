using UnityEngine;
using System.Collections;

public class GetMousePosition : MonoBehaviour {

	float damping;
	public int divideDamping;
	Vector3 centerPos;

	void Awake() {
		centerPos = new Vector3(Screen.width/2f, Screen.height/2f, 0f);
	}

	void Update() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;

		//check for deadzone
		Vector3 mouseFromCenter = Input.mousePosition - centerPos;
		damping = mouseFromCenter.magnitude/divideDamping;
		
		//"dead zone" in center % of screen's width
		float clampDistance = Screen.width * 0.02f;
		if (mouseFromCenter.magnitude < clampDistance ) {
			mouseFromCenter = Vector3.zero;
		}
		else if (Physics.Raycast(ray, out hit, 1000))
		{
			Quaternion rotationOfShip = Quaternion.LookRotation(hit.point - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotationOfShip, Time.deltaTime * damping);
		}

	}
}
