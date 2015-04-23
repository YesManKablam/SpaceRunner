using UnityEngine;
using System.Collections;

public class ClacScore : MonoBehaviour {

	public GUIText Score;
	public float score;

	// Use this for initialization
	void Start () {
		score = 0;
		//updateScore ();
	}
	
	// Update is called once per frame
	void Update () {
		updateScore ();
	}

	void updateScore()
	{
		score += Time.deltaTime;
		score = Mathf.Round (score * 100f) / 100f;
		Score.text = "Time: " + score;
	}
}
