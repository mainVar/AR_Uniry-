﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testanim : MonoBehaviour {
    public Animator Anim;
    // Use this for initialization
    void Start () {
        Anim = GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.A)) Anim.SetBool("WolfIsRun", true);
	}
}
