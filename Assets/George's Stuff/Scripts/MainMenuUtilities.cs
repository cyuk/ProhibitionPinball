using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class MainMenuUtilities : MonoBehaviour 
{
	public void loadLevel(int sceneBuildIndex)
	{
		SceneManager.LoadScene (sceneBuildIndex);
	}

	public void exitGame()
	{
		Application.Quit ();
	}

}
