using UnityEngine;
using System.Collections;

public class AnimatorTest : MonoBehaviour {

	private Animator animator;

	public GameObject	 wellLeft;
	public GameObject 	wellRight;

	void Start () {
	
		animator = this.GetComponent<Animator>();

	}
	
	void Update () {
	
		if (Input.GetKey ("left") || GameController.controle == 2) {
//			animator.SetFloat ("Blend", 0.0f);
			animator.SetInteger("Test", -1);
			wellLeft.SetActive  (true);
			wellRight.SetActive (false);

		} else if (Input.GetKey ("right") || GameController.controle == 1) {
//			animator.SetFloat ("Blend", 1.0f);
			animator.SetInteger ("Test", 1);
			wellLeft.SetActive 	(false);
			wellRight.SetActive (true);
		} else {
//			animator.SetFloat ("Blend", 0.5f);
			animator.SetInteger ("Test", 0);
			wellLeft.SetActive 	(false);
			wellRight.SetActive (false);
		}
	}
}
