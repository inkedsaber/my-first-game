using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float MoveSpeed;
    public float JumpForce;

    public Rigidbody2D RigidBody;

	// Use this for initialization
	void Start() {
        RigidBody = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update() {
        RigidBody.velocity = new Vector3(Input.GetAxis("Horizontal") * MoveSpeed, RigidBody.velocity.y);

        if (RigidBody.velocity.y == 0) {
            if (Input.GetButtonDown("Jump")) {
                RigidBody.velocity = new Vector3(RigidBody.velocity.x, JumpForce);
            }
        }
    }
}
