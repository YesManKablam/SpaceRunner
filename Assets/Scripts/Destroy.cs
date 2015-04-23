using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

	float timer = 5f;

	void OnCollisionEnter2D(){
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0)
		{
			Destroy(gameObject);
		}
	}
}
