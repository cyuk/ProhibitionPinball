using UnityEngine;
using System.Collections;

public class PullBack : MonoBehaviour {

    public Rigidbody pusherRigid;
    public float push;

	void Start () 
    {
        //Debug.Log("Messagw");
        pusherRigid = GetComponent<Rigidbody>();
	}
	
	void Update () 
    {
       // Debug.Log("IAHSOONHAOfso");
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Push");
            pusherRigid.AddForce(transform.forward * push);
        }
	}
}
