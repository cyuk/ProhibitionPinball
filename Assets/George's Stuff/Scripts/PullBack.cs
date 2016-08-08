using UnityEngine;
using System.Collections;

public class PullBack : MonoBehaviour {

    public Rigidbody pusherRigid;
    public float push;
    public Vector3 offset;
    public Vector3 dicks;
	void Start () 
    {
        //Debug.Log("Messagw");
        pusherRigid = GetComponent<Rigidbody>();
	}
	
	void Update () 
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Debug.Log("PullBack Spring disabled");
            GetComponent<SpringJoint>().spring = 0.0f;
        }
       // Debug.Log("IAHSOONHAOfso");
	    if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("PushBack if.getKey case true");
            //pusherRigid.AddForce(transform.forward * push);
            pusherRigid.AddForceAtPosition((-Vector3.forward).normalized * push, transform.position + offset);

            //transform.Translate(offset * Time.deltaTime);
            
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            //Debug.Log("PullBack Spring enabled");
            GetComponent<SpringJoint>().spring = 1500.0f;
        }
	}
}
