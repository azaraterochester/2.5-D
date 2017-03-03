using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour {

	public Transform target;
	Vector3 offset;
	float smoothing = 5f;

	// Use this for initialization
	void Start () {
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		Vector3 camPosition = target.position + offset;
		transform.position = Vector3.Lerp(transform.position, camPosition, smoothing * Time.deltaTime);
	}

}
