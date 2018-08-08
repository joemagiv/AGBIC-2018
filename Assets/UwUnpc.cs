using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UwUnpc : MonoBehaviour {

	public bool followingPlayer = false;
	public float moveSpeed = 0.05f;
	public GameObject target;
	
	public float distance;
	public float followingDistance;
	
	public GameObject maskObject;

	// Use this for initialization
	void Start () {
	
		
	}
	
	public void SpawnMask(){
		Instantiate(maskObject, transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if (followingPlayer){
			distance = Vector2.Distance(target.transform.position, transform.position);
			if(distance > followingDistance){
				transform.position = Vector2.Lerp(transform.position, target.transform.position, moveSpeed);
			}

		}
		

	}
}
