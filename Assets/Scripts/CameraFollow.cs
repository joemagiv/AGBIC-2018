using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	public Transform target;
 
	// Update is called once per frame
	void Update () 
	{
		if (target)
		{
			Vector3 point = Camera.main.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(new Vector3(
				Mathf.Clamp(transform.position.x, 1f,38.6f),
				Mathf.Clamp(transform.position.y, 0f,39.5f),
				transform.position.z), destination, ref velocity, dampTime);
		}
     
	}
}
