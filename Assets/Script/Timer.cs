using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

	public float 	  			 timeFloat;
	public int            		   timeInt;
	public static float 	timeFinal = 60;
	public Image     				 barra;
	public Color color = Color.red;

	void Start (){
		barra.fillAmount = 0.0f;
	}

	void Update () {
		
		timeFloat += Time.deltaTime;
		timeInt = (int) timeFloat;
		timeFinal = 60 - timeInt;
		barra.fillAmount += 1.0f/60*Time.deltaTime;

		if (timeFinal < 10) {
			color.a = 200;
			barra.color = color;
		}

//
//		if (timeFinal == 60) {
//			timeText.text = ("01:00");
//		}
//		if (timeFinal >= 10 && timeFinal != 60) {
//			timeText.text = ("00:" + timeFinal);
//			} else if (timeFinal < 10) {
//			  timeText.text = ("00:0" + timeFinal);
//		}
			

			
	}
}
