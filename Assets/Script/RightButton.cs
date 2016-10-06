using UnityEngine;
using System.Collections;

public class RightButton : MonoBehaviour {

	public static bool direita = false;

	void Update (){

		for (int i = 0; i < Input.touches.Length; i++) {
			 Touch touch = Input.touches [i];
			 Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (i).position);
			 RaycastHit hit = new RaycastHit ();

			 if (Physics.Raycast (ray,out hit, 1000)) {
				 if (hit.collider.gameObject == this.gameObject) {

					 switch (touch.phase) {

					 case TouchPhase.Began : direita = true;
						 break;

					 case TouchPhase.Ended:	direita = false;
						 break;
					}
				}
			}
		}
	}
}
