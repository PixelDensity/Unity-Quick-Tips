using UnityEngine;
using System.Collections;

public class ballDeath : MonoBehaviour {

	public float publicFloat;
	public bool pulbicBool;

	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	public void death ()
	{
		Destroy(this.gameObject);
	}
	
}
