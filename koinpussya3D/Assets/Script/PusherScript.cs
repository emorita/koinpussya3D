﻿using UnityEngine;
using System.Collections;

public class PusherScript : MonoBehaviour {
	private Vector3 origin;

	void Awake () {
		origin = GetComponent<Transform> ().position;
	}

	void FixedUpdate () {
		Vector3 offset = new Vector3 (0, 0, Mathf.Sin (Time.time) * 0.5f);
		GetComponent<Rigidbody> ().MovePosition (origin + offset);
	}
}
