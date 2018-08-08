using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGrow : MonoBehaviour {

	private int scalingFramesLeft = 0;

	// Use this for initialization
	void Start () {
		scalingFramesLeft = Random.Range(12,20);
	}
	
	// Update is called once per frame
	void Update () {
		
	
 
 
		if (scalingFramesLeft > 0) {
		transform.localScale = Vector3.Lerp (transform.localScale, transform.localScale * 2, Time.deltaTime * 10);
			scalingFramesLeft--;
		}
	}
}
