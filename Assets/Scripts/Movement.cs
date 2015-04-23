using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {

	//float shipBoundaryRadius = 0.5f;
	public float maxSpeed = 5f;
	public Vector2 left = new Vector2 (-2,4);
	public Vector2 right = new Vector2 (2,4);
	public Vector2 centre = new Vector2 (0,4);
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			transform.position = Vector2.MoveTowards (new Vector3 (transform.position.x, transform.position.y), left, maxSpeed * Time.deltaTime);
		} 

		else if (Input.GetKey (KeyCode.D)) {
			transform.position = Vector2.MoveTowards (new Vector3 (transform.position.x, transform.position.y), right, maxSpeed * Time.deltaTime);
		} 

		else {
			transform.position = Vector2.MoveTowards (new Vector3 (transform.position.x, transform.position.y), centre, maxSpeed * Time.deltaTime);
		}

		if(Input.touchCount > 0)
		{
			Touch touch = Input.GetTouch(0);
			if(touch.position.x < Screen.width/2)
			{
				Debug.Log("Touched");
				transform.position = Vector2.MoveTowards (new Vector3 (transform.position.x, transform.position.y), left, maxSpeed * Time.deltaTime);
			}

			else if (touch.position.x > Screen.width/2)
			{
				Debug.Log("Touched");
				transform.position = Vector2.MoveTowards (new Vector3 (transform.position.x, transform.position.y), right, maxSpeed * Time.deltaTime);
			}

			else 
			{
				transform.position = Vector2.MoveTowards (new Vector3 (transform.position.x, transform.position.y), centre, maxSpeed * Time.deltaTime);
			}
		}
	}
}