using UnityEngine;
using System.Collections;

public class Scrolling : MonoBehaviour {

	public float speed;
	private Vector2 xPos;

	// Use this for initialization
	void Start () {
		xPos = renderer.sharedMaterial.GetTextureOffset ("_MainTex");
	}
	
	// Update is called once per frame
	void Update () {
		float y = Mathf.Repeat (Time.time * speed, 1); 					// Controlls rate of the scroll by the inputed number and the time. 1 being max, as one sees you back at your starting position.
		Vector2 offset = new Vector2 (xPos.x, y); 						// Sets the offset. X is xPos, to keep what it is assigned in Unity Inspector.
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", offset);	// The renderer is then applying the changes to the quad.
	}

	void OnDisable()
	{
		renderer.sharedMaterial.SetTextureOffset ("_MainTex", xPos);	// Makes sure that X doesn't reset when the game stops.
	}
}
 