using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private Vector3 mousePosition;
	public float moveSpeed = 0.1f;
	
	public GameObject maskObject;
	
	public GameObject circleOfInfluenceObject;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			mousePosition = Input.mousePosition;
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed);
		}
		if(Input.GetMouseButtonDown(1)){
			GameObject circleClone = Instantiate(circleOfInfluenceObject, transform.position, Quaternion.identity);
			circleClone.transform.parent =  this.transform;
		}
	}
}
