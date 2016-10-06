using UnityEngine;
using System.Collections;

public class Clocks : MonoBehaviour {

	public int 		        vel;

	public static int      cont;
	public static bool clockCol;

	public float  	 respawnPos;
	private float      respawnX;
	private float        height;

	public int contgame = 0 ;



	void Start () {
		contgame++;
		float horizontal   = (float)Screen.width / (float)Screen.height;
		respawnX           = Camera.main.orthographicSize * horizontal;
		float x            = Random.Range(-respawnX+height, respawnX-height);

		height             = GetComponent<SpriteRenderer>().bounds.size.y;
		respawnPos 		   = transform.position.y;// Camera.main.orthographicSize + height*(Random.Range(3,9));
		transform.position = new Vector2(x, respawnPos);

	}
	
	void Update () {
		transform.Translate (0, -vel * Time.deltaTime, 0);


		if (transform.position.y - (height*1.5f) < -Camera.main.orthographicSize) {
			float x              = Random.Range(-respawnX + height, respawnX - height);
			transform.position   = new Vector2(x, respawnPos);

		}


	}

	void OnTriggerEnter2D (Collider2D other){
		if (other.CompareTag ("Player")) {
			clockCol = true;
			float x = Random.Range (-respawnX, respawnX);
			transform.position = new Vector2 (x, respawnPos);
			cont++;
		} 
	}
}
