﻿using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {

	public int point;

	private float Delay = 10;

	IEnumerator OnTriggerEnter2D(Collider2D c){

			FindObjectOfType<Score> ().AddPoint(point);
			GetComponent<AudioSource>().Play();
			
			yield return new WaitForSeconds (Delay);
			
			//if (gameObject.tag == "Player") {
				gameObject.GetComponent<Renderer>().enabled = true;
		//}
	}
}