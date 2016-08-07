using UnityEngine;
using System.Collections;

public class Bumper : MonoBehaviour {

	public float force = 100.0f;
	public float forceRadius = 1.0f;
	
	void OnCollisionEnter()
	{
        Debug.Log("Bumper Scipt OnCollisionEnter");
		foreach(Collider col in Physics.OverlapSphere(transform.position, forceRadius))
		{
            Debug.Log("Bumper Script foreach");
			if(col.GetComponent<Rigidbody>())
			{
                Debug.Log("Bumper Script if end");
				col.GetComponent<Rigidbody>().AddExplosionForce(force,transform.position,forceRadius);
			}
		}
	}
}
