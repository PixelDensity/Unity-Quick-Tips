using UnityEngine;
using System.Collections;

public class Instantiate : MonoBehaviour {

	public GameObject projectile;

	void Start () {
	
	}
	
	void Update () 
	{
		if(Input.GetButtonDown("Fire1"))
		{
			Instantiate(projectile, transform.position, transform.rotation);
		}
	}
}
