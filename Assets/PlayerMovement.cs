using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour { 
	
	public CharacterController2D controller;

	void Start()
    {

    }

	// Update is called once per frame
	void Update() {
		Debug.Log(Input.GetAxisRaw("Horizontal"));
	}

}
