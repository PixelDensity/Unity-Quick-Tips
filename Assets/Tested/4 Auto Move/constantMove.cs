using UnityEngine;
using System.Collections;

public class constantMove : MonoBehaviour {

	gameManager GameManager;

	void Start () 
	{
		GameObject gameController = GameObject.FindGameObjectWithTag("GameController");
		GameManager = gameController.GetComponent<gameManager>();
	}
	
	void Update () 
	{
		transform.Translate(GameManager.cubeVector * GameManager.cubeSpeed * Time.deltaTime);
	}
}
