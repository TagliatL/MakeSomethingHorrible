using UnityEngine;
using System.Collections;

public class GetMousePosition : MonoBehaviour {

	float damping;
	public int divideDamping;
	Vector3 centerPos;
	public GameObject cursor;
	public GameObject cursorCanExplode;

	void Awake() {
		centerPos = new Vector3(Screen.width/2f, Screen.height/2f, 0f);
		Cursor.visible = false;
	}

	void Update() {
		//Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		//RaycastHit hit;

		//check for deadzone
		Vector3 mouseFromCenter = Input.mousePosition - centerPos;
		damping = mouseFromCenter.magnitude/divideDamping;
		cursor.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cursor.transform.position.z);
		cursorCanExplode.transform.position = new Vector3(Input.mousePosition.x, Input.mousePosition.y, cursor.transform.position.z);
		
		//"dead zone" in center % of screen's width
		float clampDistance = Screen.width * 0.01f;
		if (mouseFromCenter.magnitude < clampDistance ) {
			mouseFromCenter = Vector3.zero;
		}
		else
		{
			Quaternion rotationOfShip = Quaternion.LookRotation(GameObject.Find("Main Camera").GetComponent<Camera>().ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, transform.position.z+50)) - transform.position);
			transform.rotation = Quaternion.Slerp(transform.rotation, rotationOfShip, Time.deltaTime * damping);
		}

	}
}
