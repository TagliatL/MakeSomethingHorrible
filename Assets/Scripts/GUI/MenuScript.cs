using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	public Canvas quitMenu;
	public GameObject startText;
	public GameObject exitText;
	private Button startButton;
	private Button exitButton;

	// Use this for initialization
	void Start ()
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startButton = startText.GetComponent<Button> ();
		exitButton = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
	}
	
	public void ExitPress()
	{
		quitMenu.enabled = true;
		startButton.enabled = false;
		exitButton.enabled = false;
	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		startButton.enabled = true;
		exitButton.enabled = true;
	}

	public void StartLevel()
	{
		Application.LoadLevel (1);
	}

	public void ExitGame()
	{
		Application.Quit ();
	}
}
