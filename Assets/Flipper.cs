using UnityEngine;
using System.Collections;

public class Flipper : MonoBehaviour 
{
	public float maxAngle = 20.0f;
	public float flipTime = 1.0f;
	public string buttonName = "Fire1";

	private Quaternion initialOrientation;

	// Use this for initialization
	void Start () 
	{
		initialOrientation = transform.rotation;
	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButton(buttonName))
		{
			//rotate the flipper
			transform.RotateAround(Vector3.down, maxAngle*Mathf.Deg2Rad/flipTime * Time.deltaTime);
		}
	}
}
