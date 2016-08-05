using UnityEngine;
using System.Collections;

public class PullBack : MonoBehaviour {

    public Rigidbody pusherRigid;
    public float push;
    public Vector3 offset;

	void Start () 
    {
        //Debug.Log("Messagw");
        pusherRigid = GetComponent<Rigidbody>();
	}
	
	void Update () 
    {
       // Debug.Log("IAHSOONHAOfso");
	    if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("Push");
            //pusherRigid.AddForce(transform.forward * push);
            pusherRigid.AddForceAtPosition((-Vector3.forward).normalized * push, transform.position + offset);
        }
	}
}
