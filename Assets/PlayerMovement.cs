using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour { 
	
	public CharacterController2D controller;

	// movement vars
	public float runSpeed = 40f;
	float horizontalMove = 0f;
	bool jump = false;
	bool crouch = false;

	void Start()
    {

    }

	// Update is called once per frame
	void Update() {
		// movement action
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

		//jump = true when arrow is pushed
		if(Input.GetButtonDown("Jump")) {
			jump = true;
		}
		
		if (Input.GetButtonDown("Crouch")){
			crouch = true;
			horizontalMove *= 0.5f;	
		} else if (Input.GetButtonUp("Crouch")){
			crouch = false;
		}
	}

	//when standing
	void FixedUpdate () {
		controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
		jump = false;
	}


}
