using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	public GameObject Player;
	public GameObject StartCamera;
	public GameObject MainCamera;
	public GameObject FinishCamera;
	public GameObject UIStart;
	public GameObject UIGame;
	public GameObject UIEndLevelLose;
	public GameObject UIEndLevelWin;

	void LaunchMission() {

		//active player
		Player.SetActive (true);

		//switch cameras
		StartCamera.SetActive (false);
		MainCamera.SetActive (true);

		//switch GUI
		UIStart.SetActive (false);
		UIGame.SetActive (true);

	}

	void Win() {
		//switch cameras
		MainCamera.SetActive (false);
		FinishCamera.SetActive (true);
		UIEndLevelWin.SetActive (true);
	}

	void Lose() {
		//switch cameras
		UIEndLevelLose.SetActive (true);
	}

	void Start () {
		Invoke ("LaunchMission", 3.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
