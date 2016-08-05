using UnityEngine;
using System.Collections;

public class FlipperBehaviour : MonoBehaviour {

	HingeJoint flipperLHinge;
	JointMotor motor;
	public KeyCode button;
	// Use this for initialization
	void Start () 
	{
		GetComponent<Rigidbody> ().maxAngularVelocity = 100f;
		//motor.force = 0;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (button) || Input.GetKeyUp (button)) 
		{
			HingeJoint hinge = GetComponent<HingeJoint> ();
			JointMotor motor = hinge.motor;
			motor.targetVelocity = -motor.targetVelocity;
			hinge.motor = motor;
		}
	}
}
