using UnityEngine;
using System.Collections;

public class removerScript : MonoBehaviour {
	public GameObject uScore;

	void OnTriggerEnter (Collider col){
		Destroy (col.gameObject);
		uScore.SendMessage("CountUp");
	}
}
