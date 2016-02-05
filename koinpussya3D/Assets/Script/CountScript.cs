using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class CountScript : MonoBehaviour{

	int score = 30; //初期値を30に変更
	private Text uScore;

	void Start() {
		uScore = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
		uScore.text = "Score: " + score.ToString();
	}

	void CountUp() {
		score += 3;
		uScore.text = "Score: " + score.ToString();
	}
}
