﻿using UnityEngine;
using System.Collections;

public class FlipperMovement : MonoBehaviour 

{
	//Declare variables for flipper object

	public string button = "Fire1";
	public Vector3 forceDirection = Vector3.forward;
	public float order = 1000.0f; // offset
	public Vector3 balance;

	// Update is called once per frame
	void Update ()
	{
		if(Input.GetButton(button))
		{
            //Debug.Log("FlipperMovement if.getbutton case true");
			GetComponent<Rigidbody>().AddForceAtPosition(forceDirection.normalized*order,transform.position+balance);
		}
		else
		{
            //Debug.Log("FlipperMovement if.getbutton case false");
			GetComponent<Rigidbody>().AddForceAtPosition(forceDirection.normalized*-order,transform.position+balance);
		}
	}
}
