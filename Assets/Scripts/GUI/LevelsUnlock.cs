using UnityEngine;
using System.Collections;

public class LevelsUnlock : MonoBehaviour {

	public GameObject[] levels;
	public GameObject[] lockedLevels;

	void Start () {
		for (int i = 0; i < PlayerPrefs.GetInt ("NumberOfLevelWon"); i++) {
			lockedLevels[i].gameObject.SetActive (false);
			levels[i].gameObject.SetActive (true);
		}
	}
}
