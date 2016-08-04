using UnityEngine;
using System.Collections;

public class ControllerFreecam : MonoBehaviour {
	float flySpeed = 0.5f;
	GameObject defaultCamera;
	GameObject playerObject;
	bool isEnabled;
	bool shift;
	bool ctrl;
	float accelerationAmount = 3.0f;
	float accelerationRatio = 1.0f;
	float slowDownRatio = 0.5f;

	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.LeftShift) || Input.GetKeyUp (KeyCode.LeftShift)) {

		}
	}
}
