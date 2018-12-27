using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour {

    public int MaxHealth;
    public int CurrentHealth;

	// Use this for initialization
	void Start() {
		CurrentHealth = MaxHealth;
	}

	// Update is called once per frame
	void Update() {

	}

    public void HurtPlayer(int Damage) {
        CurrentHealth -= Damage;
    }

    public void HealPlayer(int HealAmount) {
        CurrentHealth += HealAmount;
        if (CurrentHealth > MaxHealth) {
            CurrentHealth = MaxHealth;
        }
    }
}
