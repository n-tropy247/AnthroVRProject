using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeToPA : MonoBehaviour {

	public string levelToLoad;
	private float timer;

	// Use this for initialization
	void Start () {
		timer = 10f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;

		if (timer <= 0)
        {
			Application.LoadLevel(levelToLoad);
        }
	}
}
