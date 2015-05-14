using UnityEngine;
using System.Collections;

public class GameMusic : MonoBehaviour {

	void Awake ()
	{
		GameObject menuMusic = GameObject.Find("MenuMusic");
		if (menuMusic)
		{
			Destroy(menuMusic);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
