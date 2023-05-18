using UnityEngine;

public class GameManager : MonoBehaviour
{
	public AudioManager gameAudioManager;
	private UIManager gameUIMngr;
	private SpawnManager itemsSpawner;
	private int score;

    void Start()
    {
		gameUIMngr = GetComponent<UIManager>();
		itemsSpawner = GetComponent<SpawnManager>();
		score = 0;
		EventsRock.current.OnCatchItem += CatchItem;
    }

    void Update()
    {
		gameUIMngr.DisplayScore(score);
		if(score < 0)
		{
			GameOver();
		}
    }

	private void GameOver()
	{
		gameUIMngr.DisplyGameOver();
		Time.timeScale = 0;
	}

	public void RestartGame()
	{
		Destroy(GameObject.FindWithTag("Cool"));
		Destroy(GameObject.FindWithTag("Lame"));
		score = 0;
		gameUIMngr.RemoveGameOverCanvas();
		Time.timeScale = 1;
	
	}

	private void CatchItem(string itemTag)
	{
		if(itemTag == "Cool")
		{
			score++;
			gameAudioManager.PlayClip(0);
		}
		else if(itemTag == "Lame")
		{
			score--;
			gameAudioManager.PlayClip(1);
		}
	}

	public void QuitButton()
	{
		Application.Quit();
	}

	private void OnDisable()
	{
		EventsRock.current.OnCatchItem -= CatchItem;
	}
}
