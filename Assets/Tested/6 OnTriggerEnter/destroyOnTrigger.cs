using UnityEngine;
using System.Collections;

public class destroyOnTrigger : MonoBehaviour 
{
	void OnTriggerEnter (Collider coll)
	{
		Destroy(gameObject);
	}
}
