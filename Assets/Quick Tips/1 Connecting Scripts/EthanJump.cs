using UnityEngine;
using System.Collections;

public class EthanJump : MonoBehaviour {

	ballDeath ball;
	EthanCar car;

	void Start () 
	{
		GameObject ballScript = GameObject.FindGameObjectWithTag("Ball");
		ball = ballScript.GetComponent<ballDeath>();

		car = this.gameObject.GetComponent<EthanCar>();
	}

	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			car.Car();
			ball.death();
		}
	}
}
