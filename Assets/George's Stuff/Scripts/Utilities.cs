using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class Utilities : MonoBehaviour 
{
	void Start ()
	{
		Time.timeScale = 1.0f;
	}

	public CanvasGroup UI, Pause, Death;

	public void loadLevel(int sceneBuildIndex)
	{
		SceneManager.LoadScene (sceneBuildIndex);
	}

	public void exitGame()
	{
		Application.Quit ();
	}

	public void pauseGame()
	{
		if (Time.timeScale == 1.0f) 
		{
			Time.timeScale = 0.0f;
		} 
		else 
		{
			Time.timeScale = 1.0f;
		}
	}

	public void pauseMenu()
	{
		if (UI.alpha == 1.0f) 
		{
			UI.alpha = 0.0f;
			UI.blocksRaycasts = false;
			UI.interactable = false;

			Pause.alpha = 1.0f;
			Pause.blocksRaycasts = true;
			Pause.interactable = true;
		} 
		else 
		{
			Pause.alpha = 0.0f;
			Pause.blocksRaycasts = false;
			Pause.interactable = false;

			UI.alpha = 1.0f;
			UI.blocksRaycasts = true;
			UI.interactable = true;
		}
		pauseGame ();
	}

	public void deathMenu()
	{
		UI.alpha = 0.0f;
		UI.blocksRaycasts = false;
		UI.interactable = false;

		Death.alpha = 1.0f;
		Death.blocksRaycasts = true;
		Death.interactable = true;
	}
}
