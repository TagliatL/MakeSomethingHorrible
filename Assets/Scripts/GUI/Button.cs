using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	void Retry() {
		Application.LoadLevel(Application.loadedLevelName);
	}

	void Menu() {
		Application.LoadLevel ("LevelSelection");
	}
}
