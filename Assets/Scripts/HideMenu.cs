using UnityEngine;
using System.Collections;

public class HideMenu : MonoBehaviour {
		
	public int wait = 5;
	public GameObject player;
	
	void Start()
	{
		player = (GameObject)GameObject.FindWithTag ("Player");
	}
	// Update is called once per frame
/*	void Update () {
		if (player == null)
		{
			for(int i = 0;  i <= wait; i++)
			{
				i++;
				Application.LoadLevel(0);
			}
		}
	}*/
}
