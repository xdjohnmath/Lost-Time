using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class GameController : MonoBehaviour {

	public  int  		   vel;
	public  GameObject   pause;

	private float  widthPlayer;
	private float 	   cameraW;
	private bool	    paused;

	//public int contgame = 0 ;

	public GameObject rabbit;
	public static int controle;


	void Start(){

		Timer.timeFinal = 60;

		Screen.sleepTimeout = SleepTimeout.NeverSleep;

		cameraW     = Camera.main.orthographicSize;
		widthPlayer	= GetComponent<SpriteRenderer>().bounds.size.x;

		pause.SetActive (false);


	}

	void Update () {
		Move ();
		ChangeScene ();
		GamePause ();
	
	}




	void Move(){
//		if (transform.position.x > ((-cameraW + widthPlayer) / 2)-0.2f) { 
//			if (Input.GetKey ("left") || LeftButton.esquerda == true) {
//				transform.Translate (-vel * Time.deltaTime, 0, 0);
//			}
//
//		}
//
//		if (transform.position.x < ((cameraW - widthPlayer) / 2)+0.2f) { 
//			if (Input.GetKey ("right") || RightButton.direita == true) {
//				transform.Translate (vel * Time.deltaTime, 0, 0);
//			}
//
//		}

		if (Input.GetKey ("right") ||controle == 1) {
			if (transform.position.x < ((cameraW - widthPlayer) / 2)+0.2f) { 
				rabbit.transform.Translate (vel * Time.deltaTime, 0, 0);
			}
		} else if (Input.GetKey ("left") ||controle == 2) {
			if (transform.position.x > ((-cameraW + widthPlayer) / 2)-0.2f) { 
				rabbit.transform.Translate (-vel * Time.deltaTime, 0, 0);
			}
		} else {
			rabbit.transform.Translate (0,0,0);
		}


	}

	public void Direita(){
		controle = 1;
	}
	public void Esquerda(){
		controle = 2;
	}
	public void Up(){
		controle = 0;
	}


	void GamePause(){
		if (Input.GetKeyDown(KeyCode.Escape)) {
			if (paused == true) {
				Time.timeScale = 1;	
				paused = false;
				pause.SetActive (false);
			} else {
				Time.timeScale = 0;
				paused = true;
				pause.SetActive (true);
			}
		}
	}

	public void ChangeScene(){
		if (Timer.timeFinal == 0) {
			SceneManager.LoadScene ("Ending");         //Fim do Jogo
		}
	
	}


	public void Exit(){
		Application.Quit();
	}
	public void Return(){
		Time.timeScale = 1;
		pause.SetActive (false);
	}




}//Close Class

