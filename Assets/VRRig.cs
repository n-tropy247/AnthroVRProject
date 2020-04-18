using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRRig : MonoBehaviour {

	public bool inputA;
	private bool prevInput = false;
	public GameObject rCube;

	// Update is called once per frame
	void Update () {

		inputA = OVRInput.Get(OVRInput.RawButton.A);

		if (inputA != prevInput)
        {
			ButtonStateChanged();
        }
		
	}

	void ButtonStateChanged()
    {
		if (prevInput == false) //new press
		{
			rCube?.SetActive(false);
		}

		prevInput = inputA;
    }
}
