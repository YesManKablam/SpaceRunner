using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class playerScore : MonoBehaviour {

	public Text screenScore;
	public Text screenHigh;
	public Text screenLast;
	public float tempScore;
	public float tempHigh;
	public float tempLast;

	// Use this for initialization
	void Start () {
		Debug.Log (PlayerPrefs.GetFloat("score"));
		if(!PlayerPrefs.HasKey("high"))
			PlayerPrefs.SetFloat("high", 0);

		if(!PlayerPrefs.HasKey("last"))
			PlayerPrefs.SetFloat("last", 0);

		tempScore = PlayerPrefs.GetFloat ("score");
		tempHigh = PlayerPrefs.GetFloat ("high");
		tempLast = PlayerPrefs.GetFloat ("last");

		if(tempScore >= tempHigh)
		{
			PlayerPrefs.SetFloat("high", tempScore);
		}

		screenScore.text = "Your Time: " + tempScore.ToString();
		screenHigh.text = "Best Time: " + tempHigh.ToString ();
		screenLast.text = "Last Time: " + tempLast.ToString ();

		PlayerPrefs.SetFloat ("last", tempScore);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
