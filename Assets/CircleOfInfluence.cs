using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleOfInfluence : MonoBehaviour {

	private int scalingFramesLeft = 0;


	// Use this for initialization
	void Start () {
		scalingFramesLeft = 45;
	}
	
	void OnTriggerEnter2D(Collider2D other){
		if(other.GetComponent<UwUnpc>()){
			UwUnpc npc = other.GetComponent<UwUnpc>();
			if (npc.followingPlayer){
				npc.SpawnMask();
			} else {
				npc.followingPlayer = true;
			}
		} 
	}
	
	// Update is called once per frame
	void Update () {
		if (scalingFramesLeft > 0) {
			transform.localScale = Vector3.Lerp (transform.localScale, transform.localScale * 2, Time.deltaTime * 2);
			scalingFramesLeft--;
		} else {
			Destroy(this.gameObject);
		}
		
	}
}
