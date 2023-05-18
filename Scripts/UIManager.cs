using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
	public TMP_Text scoreText;
	public GameObject gameOverCanvas;
	public TMP_Text gameOverText;

	public void DisplayScore(int score)
	{
		scoreText.text = "Score: " + score.ToString();
	}

	public void DisplyGameOver()
	{
		gameOverText.text = "Too much uncool items. How lame.";
		gameOverCanvas.SetActive(true);
	}

	public void RemoveGameOverCanvas()
	{
		gameOverCanvas.SetActive(false);
	}

}
