using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour {
	
	public GameObject coinPrefab;

	void Update()
	{
		if (Input.GetMouseButtonDown (0)) {
			Vector3 offset = new Vector3 (Mathf.Sin (Time.time * 16), 0, 0);
			Instantiate (coinPrefab, transform.position + offset, transform.rotation);
		}
	}
}