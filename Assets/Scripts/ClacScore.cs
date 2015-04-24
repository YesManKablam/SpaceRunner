using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClacScore : MonoBehaviour {

	public Text Score;										// This is so that we can display our current score	
	public float score;										// This is the score itself
	
	void Start () {
		score = 0; 											// Initialise the score float
	}

	void Update () {
		updateScore ();										// Update gets called every frame, so this will update the score on the screen every frame
	}

	void updateScore()
	{
		score += Time.deltaTime;							// Our score is increased by realtime
		score = Mathf.Round (score * 100f) / 100f;			// This rounds our score to 2 decimals
		Score.text = "Time: " + score;						// This writes our score to the screen
	}
}
