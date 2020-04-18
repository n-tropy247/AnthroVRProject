using System.Collections;
using System.Collections.Generic;
using Wrld;
using Wrld.Space;
using UnityEngine;

public class TerrainChanger : MonoBehaviour {

	private float timer = 20.0f;
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0.0f)
        {
			Api.Instance.CameraApi.MoveTo(LatLong.FromDegrees(37, -122), distanceFromInterest: 500);
		}
	}
}
