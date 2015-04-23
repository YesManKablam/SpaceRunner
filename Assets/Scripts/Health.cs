using UnityEngine;
using System.Collections;

public class Health : MonoBehaviour {

	public float health = 3;
	public float wait = 5f;
	public bool dead;

	void OnCollisionEnter2D()
	{
		health -= 1;
		if (health <= 0) 
		{
			renderer.enabled = false;
			Destroy(collider2D);
			dead = true;
		}
	}

	// Update is called once per frame
	void Update () {
		if (dead)
		{ 
			wait -= Time.deltaTime;

			if (wait <=0)
			Application.LoadLevel ("_Scene_3");
		}
	}
}
