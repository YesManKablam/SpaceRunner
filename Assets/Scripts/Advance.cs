using UnityEngine;
using System.Collections;

public class Advance : MonoBehaviour {

	public float speed = 30f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 pos = transform.position;
//		Vector2 velocity = new Vector2 (0, speed * Time.deltaTime);
		transform.position = pos;
	}
}
