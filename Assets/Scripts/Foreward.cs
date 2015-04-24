using UnityEngine;
using System.Collections;

public class Foreward : MonoBehaviour {
	 
	public float diff = 60f;

	// Update is called once per frame
	void Update () {
		float maxSpeed = 10f;
		diff -= Time.deltaTime;
		if(diff <= 20 )
		{
			maxSpeed = 15f;
		}
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3 (0, maxSpeed * Time.deltaTime, 0);
		
		pos += transform.rotation * velocity;
		
		transform.position = pos;


	}
}
