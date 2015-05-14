using UnityEngine;
using System.Collections;

public class MenuMusic : MonoBehaviour {

	void Awake ()
	{
		GameObject gameMusic = GameObject.Find("GameMusic");
		if (gameMusic)
		{
			Destroy(gameMusic);
		}
		DontDestroyOnLoad(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
