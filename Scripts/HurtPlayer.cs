﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

    public int DealDamage;

	// Use this for initialization
	void Start() {

	}

	// Update is called once per frame
	void Update() {

	}

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag == "Player") {
            FindObjectOfType<HealthManager>().HurtPlayer(DealDamage);
        }
    }
}
