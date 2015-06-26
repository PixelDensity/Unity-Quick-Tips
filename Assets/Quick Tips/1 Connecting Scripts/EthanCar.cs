using UnityEngine;
using System.Collections;

public class EthanCar : MonoBehaviour {

	public GameObject car;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void Car ()
	{
		Instantiate(car, car.transform.position, car.transform.rotation);
	}
}
