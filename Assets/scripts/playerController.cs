using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	public float runSpeed;
	Animator myAC;
	Rigidbody myRB;
	bool facingRight;

	// Use this for initialization
	void Start () {
		myAC = GetComponent<Animator>();
		myRB = GetComponent<Rigidbody>();
		facingRight = true;
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){

		float movement = Input.GetAxis("Horizontal");
		myAC.SetFloat("speed",Mathf.Abs(movement));
		myRB.velocity = new Vector3(movement * runSpeed, myRB.velocity.y, 0);

		if(movement > 0 && !facingRight) flip();
		else if(movement < 0 && facingRight) flip();

	}

	void flip(){
		facingRight = !facingRight;
		Vector3 scale = transform.localScale;
		scale.z *= -1;
		transform.localScale = scale;
	}
}
