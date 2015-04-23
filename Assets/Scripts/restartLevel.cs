using UnityEngine;
using System.Collections;

public class restartLevel : MonoBehaviour {

	public void LoadScene(int level)
	{
		Application.LoadLevel (level);
	}

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			Application.Quit();
		}
	}
}
