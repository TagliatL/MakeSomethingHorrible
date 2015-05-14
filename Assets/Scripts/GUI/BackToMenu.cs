using UnityEngine;
using System.Collections;

public class BackToMenu : MonoBehaviour {
	public float time;

	void ToMenu() {
		Application.LoadLevel ("LevelSelection");
	}
	void OnEnable() {
		Invoke ("ToMenu", time);
	}
}
