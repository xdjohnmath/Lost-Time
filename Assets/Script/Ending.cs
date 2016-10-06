using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Ending : MonoBehaviour {

	public  GameObject credits;


	void Start (){
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		credits.SetActive (false);
	}

	public void Menu(){ 
		SceneManager.LoadScene ("MenuInicial");
	}

	public void Exit(){
		Application.Quit();
	}

	public void Destroy(){
		Destroy (gameObject);
	}

	public void NovoJogo(){
	//	Application.LoadLevel ("Jogo");
		SceneManager.LoadScene ("Jogo");
		Clocks.cont = 0;
	}

	public void CreditsOn(){
		credits.SetActive (true);
	}

	public void CreditsOff(){
		credits.SetActive (false);
	}

	public void Instructions(){
		//	Application.LoadLevel ("Jogo");
		SceneManager.LoadScene ("Instructions");
	}

}



//	IEnumerator Changelevel (){
//		float fadeTime = GameObject.Find ("_GM").GetComponent<Fading>().BeginFade (1); 	
//		yield return new WaitForSeconds (fadeTime);
//	}