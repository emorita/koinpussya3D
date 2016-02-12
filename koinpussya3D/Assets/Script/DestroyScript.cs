using UnityEngine;
using System.Collections;

public class DestroyScript : MonoBehaviour {

	void OnTriggerEnter(Collider col) {
		Destroy (col.gameObject);
	}
}