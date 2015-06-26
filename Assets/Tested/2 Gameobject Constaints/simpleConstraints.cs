using UnityEngine;
using System.Collections;

public class simpleConstraints : MonoBehaviour {

	public float moveSpeed = 1.0f;
	public Vector2 xCon;
	public Vector2 yCon;
	Vector2 wantaBePos;

	void Start () 
	{
	
	}
	
	void Update () 
	{
		wantaBePos+= new Vector2(Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime, Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime);
		transform.position = new Vector3(Mathf.Clamp(wantaBePos.x, xCon.x, xCon.y), Mathf.Clamp(wantaBePos.y, yCon.x, yCon.y), 0);
	}
}
