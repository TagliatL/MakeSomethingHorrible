using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MenuScript : MonoBehaviour
{
	public Canvas quitMenu;
	public Canvas tutoMenu;
	public GameObject startText;
	public GameObject tutoText;
	public GameObject exitText;
	private Button startButton;
	private Button tutoButton;
	private Button exitButton;

	// Use this for initialization
	void Start ()
	{
		quitMenu = quitMenu.GetComponent<Canvas> ();
		startButton = startText.GetComponent<Button> ();
		tutoButton = tutoText.GetComponent<Button> ();
		exitButton = exitText.GetComponent<Button> ();
		quitMenu.enabled = false;
		tutoMenu.enabled = false;
	}

	public void TutoPress()
	{
		tutoMenu.enabled = true;
		startButton.enabled = false;
		tutoButton.enabled = false;
		exitButton.enabled = false;
	}
	
	public void IGotItPress()
	{
		tutoMenu.enabled = false;
		startButton.enabled = true;
		tutoButton.enabled = true;
		exitButton.enabled = true;
	}

	public void ExitPress()
	{
		quitMenu.enabled = true;
		startButton.enabled = false;
		tutoButton.enabled = false;
		exitButton.enabled = false;
	}

	public void NoPress()
	{
		quitMenu.enabled = false;
		startButton.enabled = true;
		tutoButton.enabled = true;
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
