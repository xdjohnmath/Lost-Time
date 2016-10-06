using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClockCatcher : MonoBehaviour {

	public static int 	convPoint;
	public Text            points;

	void Update () {
		convPoint = 10 * Clocks.cont;
		points.text = (""+convPoint);
	}
}
