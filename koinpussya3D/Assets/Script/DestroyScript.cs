using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	void OnTriggerEnter(Color col) {
		Destroy (col.gameObject);
	}
}