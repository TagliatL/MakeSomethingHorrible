using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;


public class LevelManager : MonoBehaviour {

	public GameObject Player;
	public GameObject StartCamera;
	public GameObject MainCamera;
	public GameObject FinishCamera;
	public GameObject UIStart;
	public GameObject UIGame;
	public GameObject UIEndLevelLose;
	public GameObject UIEndLevelWin;
	public GameObject LaunchText;
	public GameObject LaunchImage;
	bool readyToStart;
	Vector3 centerPos;

	void Awake() {
		centerPos = new Vector3(Screen.width/2f, Screen.height/2f, 0f);
	}
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

	void LaunchMissionUI() {
		LaunchText.SetActive (true);
		LaunchImage.SetActive (true);
		readyToStart = true;
	}

	
	void UpdateProgression(int lastLevelWon) {
			if(lastLevelWon > PlayerPrefs.GetInt ("NumberOfLevelWon"))
				PlayerPrefs.SetInt ("NumberOfLevelWon", lastLevelWon);
	}

	void Win() {
		//switch cameras
		MainCamera.SetActive (false);
		FinishCamera.SetActive (true);
		UIEndLevelWin.SetActive (true);
		//setTheProgressionOfThePlayer
		UpdateProgression (int.Parse(Regex.Replace(Application.loadedLevelName, "[^0-9]", "")));
	}

	void Lose() {
		//switch cameras
		UIEndLevelLose.SetActive (true);
	}

	void Start () {
		Invoke ("LaunchMissionUI",2f);
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 mouseFromCenter = Input.mousePosition - centerPos;
		float clampDistance = Screen.width * 0.02f;
		if (readyToStart && mouseFromCenter.magnitude < clampDistance) {
			Invoke("LaunchMission",0.5f);
		}
	}
}
