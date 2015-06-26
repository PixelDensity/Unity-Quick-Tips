using UnityEngine;
using System.Collections;

public class randomRotate : MonoBehaviour {

	public float rotateRate = 1.0f;
	public float InvokeRate = 1.0f;

	float xRot;
	float yRot;
	float zRot;
	float wRot;


	void Start () 
	{
		InvokeRepeating("newRotate", 0.0f, InvokeRate);
	}
	
	void Update () 
	{
	
		Quaternion RandomQuat = new Quaternion(xRot, yRot, zRot,wRot);
		transform.rotation = Quaternion.Slerp (transform.rotation, RandomQuat, rotateRate * Time.deltaTime);
	}

	void newRotate ()
	{
		xRot = Random.Range(-720, 720);
		yRot = Random.Range(-720, 720);
		zRot = Random.Range(-720, 720);
		wRot = Random.Range(-720, 720);
	}
}
