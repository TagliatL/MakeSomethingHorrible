using UnityEngine;
using System.Collections;

public class LevelsUnlock : MonoBehaviour {

	public GameObject[] levels;
	public GameObject[] lockedLevels;

	void Start () {
		if (PlayerPrefs.GetInt ("NumberOfLevelWon") != null || PlayerPrefs.GetInt ("NumberOfLevelWon") > 0) {
			for (int i = 0; i < PlayerPrefs.GetInt ("NumberOfLevelWon"); i++) {
				lockedLevels[i].gameObject.SetActive (false);
				levels[i].gameObject.SetActive (true);
				Debug.Log (PlayerPrefs.GetInt ("NumberOfLevelWon"));
			}
		}
	}
}
