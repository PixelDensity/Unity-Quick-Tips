using UnityEngine;
using System.Collections;

public class pointChooser : MonoBehaviour {

	public Transform[] points;
	public float InvokeRate = 1.0f;

	void Start () 
	{
		InvokeRepeating("pickPoints", 1, InvokeRate);
	
	}

	void pickPoints ()
	{
		int indexNum = Random.Range(0, points.Length);
		Debug.Log(points[indexNum].name);
	}
}
