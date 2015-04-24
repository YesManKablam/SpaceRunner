using UnityEngine;
using System.Collections;

public class SpawnSettings : MonoBehaviour {
	public GameObject BeamBundle_0;
	GameObject beamInstance;
	public float delay;
	public int spawnPos;
	public int i = 0;
	public float difficulty = 60f;
	// Use this for initialization
	void Start () {
	
	}

	void spawnBeams()
	{
		spawnPos = Random.Range (1, 4);

		if (difficulty >= 50f) {
			delay = .85f;
		} else if (difficulty >= 35f) {
			delay = .75f;
		} 
		else if(difficulty >= 20f)
		{
			delay = .65f;
		}else {
			delay = .5f;
		}
		//beamInstance = (GameObject)Instantiate (BeamBundle_0, transform.position, Quaternion.identity);
		if (spawnPos == 1) {
			beamInstance = (GameObject)Instantiate (BeamBundle_0, new Vector3 (2, -7, 0), Quaternion.identity);
		} else if (spawnPos == 2) {
			beamInstance = (GameObject)Instantiate (BeamBundle_0, new Vector3 (-2, -7, 0), Quaternion.identity);
		} else {
			beamInstance = (GameObject)Instantiate (BeamBundle_0, new Vector3(0,-7,0), Quaternion.identity);
		}
	}

	// Update is called once per frame
	void Update () {
		for (i = 0; i< delay; i++) 
		{
			difficulty -= Time.deltaTime;
			delay -=Time.deltaTime;
			if (i > delay)
			{
				spawnBeams ();

			}
		}
	}
}