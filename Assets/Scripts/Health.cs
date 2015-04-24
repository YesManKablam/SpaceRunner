using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Health : MonoBehaviour {

	public float health = 3;
	public float wait;
	public bool dead;
	public GameObject getScore;
	public float tempGetScore;
	public Text Life;

	void Start(){
		getScore = GameObject.Find ("Canvas");									// This looks for the game object in the current scene called Canvas. This is because Canvas has the score calculator in it
	}

	void OnCollisionEnter2D()
	{
		health -= 1;															// Everytime you make contact with an enemy, you lose a hitpoint
		if (health <= 0) 														// When you are out of health....
		{
			renderer.enabled = false;											// This hides the player's sprite
			Destroy(collider2D);												// And this deletes it's collison, so that it will no longer collide when waiting for the game over page to load
			dead = true;														// This flag gets set
		}
	}

	// Update is called once per frame
	void Update () {

		Life.text = "Lives: " + health;
		if (dead)																// If the bool is true
		{ 
			tempGetScore = getScore.GetComponent<ClacScore>().score;			// This will use a temporary float that will be assigned the score value from the game object of Canvas
			tempGetScore -= 2.5f;												// This justs make sure that your time is based off the actual time not including the buffer
			PlayerPrefs.SetFloat("score", tempGetScore);						// This will then save that float to a file in unity's file system.
			wait -= Time.deltaTime;												// This is a little buffer between death and the game over menu. This was original setup in the update function of the score calculator. However, calling the values here and writing to file uses far less resorces then writting it to file every 1/60th of a second


			if (wait <=0)														// After the delay
			Application.LoadLevel ("_Scene_3");									// Loads the game over scene
		}		
	}
}
