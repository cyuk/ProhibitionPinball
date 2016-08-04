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
		if (Input.GetKeyDown (KeyCode.LeftShift) || Input.GetKeyDown (KeyCode.RightShift)) 
        {
            shift = true;
            flySpeed *= accelerationRatio;
		}

        if(Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            shift = false;
            flySpeed /= accelerationRatio;
        }

        if(Input.GetKeyDown(KeyCode.LeftControl)||Input.GetKeyDown(KeyCode.RightControl))
        {
            ctrl = true;
            flySpeed *= slowDownRatio;
        }

        if(Input.GetKeyUp(KeyCode.LeftControl)||Input.GetKeyUp(KeyCode.RightControl))
        {
            ctrl = false;
            flySpeed /= slowDownRatio;
        }

        if(Input.GetAxis("Vertical") != 0)
        {
            transform.Translate(-defaultCamera.transform.forward * flySpeed * Input.GetAxis("Vertical"));
        }

        if(Input.GetAxis("Horizontal") != 0)
        {
            transform.Translate(defaultCamera.transform.right * flySpeed * Input.GetAxis("Horizontal"));
        }

        if(Input.GetKey(KeyCode.E))
        {
            transform.Translate(defaultCamera.transform.up * flySpeed * 0.5f);
        }

        if(Input.GetKey(KeyCode.Q))
        {
            transform.Translate(-defaultCamera.transform.up * flySpeed * 0.5f);
        }

        //if(Input.GetKeyDown(KeyCode.F12))
       // {
       //     switchCamera();
       // }

        if(Input.GetKeyDown(KeyCode.M))
        {
            playerObject.transform.position = transform.position;
        }
	}
}
