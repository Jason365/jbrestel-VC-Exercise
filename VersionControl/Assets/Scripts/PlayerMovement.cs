﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed;
    public float rotRate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0f, 0f, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0f, Input.GetAxis("Horizontal") * rotRate * Time.deltaTime, 0f);
	}
}
