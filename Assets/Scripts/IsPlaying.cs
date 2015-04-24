using UnityEngine;
using System.Collections;

public class IsPlaying : MonoBehaviour {
	public AudioClip audioClip;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (audio.isPlaying) {
			audio.clip = audioClip;
			audio.Stop();
		}
	}
}
