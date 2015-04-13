using UnityEngine;
using System.Collections;

public class BackgroundColor : MonoBehaviour {

	public Color lerpedColor = Color.blue;
	void Update() {
		lerpedColor = Color.Lerp(Color.blue, Color.cyan, Time.time);
		GetComponent<Renderer> ().material.color = lerpedColor;
	}
}
