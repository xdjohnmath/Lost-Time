using UnityEngine;
using System.Collections;

public class ColisionAnimatorTest : MonoBehaviour {

	private Animator animator;

	void Start () {
		animator 	= this.GetComponent<Animator> ();
	}

	void Update(){
	
		if (Clocks.clockCol == true) {
			StartCoroutine (ColTrue());
		} else {
			animator.SetInteger ("Colision", 0);
		}
	}

	IEnumerator ColTrue (){
		animator.SetInteger ("Colision", 1);
		yield return new WaitForSeconds (0.3f);
		Clocks.clockCol = false;
	}

}

	