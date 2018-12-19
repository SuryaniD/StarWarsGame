﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDestroy : MonoBehaviour {

    private ParticleSystem particleSystem;

	// Use this for initialization
	void Start () {
        particleSystem = GetComponent<ParticleSystem>();

    }
	
	// Update is called once per frame
	void Update () {
		if (!particleSystem.IsAlive())
        {
            Destroy(gameObject);
        }
	}
}
