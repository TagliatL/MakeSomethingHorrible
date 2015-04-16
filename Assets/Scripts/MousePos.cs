using UnityEngine;
using System.Collections;

public class MousePos : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		// ----------------FLying rotation Controls      ---------------------//
		
		//for mouse movement
		float yawMouse = Input.GetAxis("Mouse X");
		float pitchMouse = Input.GetAxis("Mouse Y");        
		Vector3 targetFlyRotation = Vector3.zero;
		
		Screen.lockCursor = true;
		
		if (Mathf.Abs(yawMouse) > 0.1f || Mathf.Abs(pitchMouse) > 0.1f) 
		{
			targetFlyRotation = yawMouse * transform.right + pitchMouse * transform.up;
			targetFlyRotation.Normalize();
			targetFlyRotation *= Time.deltaTime * 3.0f;
			
			
			//limit x rotation if looking too much up or down
			//Log out the limitX value for this to make sense
			//float limitX = Quaternion.LookRotation(moveDirection + targetFlyRotation).eulerAngles.x;
			
			
			//70 sets the rotation limit in the down direction
			//290 sets limit for up direction
			//if (limitX < 90 && limitX > 70 || limitX > 270 && limitX < 290) 
		//	{
				//Debug.Log("restrict motion");
			//}
			//else
			//{
				//moveDirection += targetFlyRotation;
				//does the actual rotation on the object if no limits are breached
				//transform.rotation = Quaternion.LookRotation(moveDirection);
			//}
			
			//just tells the playerManager where to Look for the aim target.
			//Vector3 newLookDirection = lookObject.transform.position -  transform.position;
			//newLookDirection.Normalize();
			
			//playerManager.LookDirection(newLookDirection);
			
			
		}
	}
}
