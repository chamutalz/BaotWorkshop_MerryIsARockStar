using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuBehaviour : MonoBehaviour
{
	public void StartGame()
	{
		SceneManager.LoadScene("Main");
	}

	public void Quit()
	{
		Application.Quit();
	}
}
