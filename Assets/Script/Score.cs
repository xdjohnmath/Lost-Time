using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {


	private int 		score = ClockCatcher.convPoint;
	public int 		highScore = 0;
	string 	   	 highScoreKey = "HighScore";
	public 		   Text highs;
	public 	 Text scoreScreen;

	void Start(){
		highScore = PlayerPrefs.GetInt(highScoreKey,0);    
	}

	void Update(){
		scoreScreen.text = ("" + score);
		highs.text  	 = ("Highscore \n" + highScore);
	}


	void OnDisable(){
		if(score>highScore){
			PlayerPrefs.SetInt(highScoreKey, score);
			PlayerPrefs.Save();
		}
	}

}
