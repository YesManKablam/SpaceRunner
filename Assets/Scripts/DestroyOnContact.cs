using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

	// Use this for initialization
	void OnCollisionEnter2D(){
		//damage += 1;
		//invul += 10;
		//gameObject.layer = 10;
		//if (damage >= 3) {
			Destroy (gameObject);
		//}
	}
	// Update is called once per frame
	void Update () {
		//if()
		//OnCollisionEnter2D ();
	}
}
