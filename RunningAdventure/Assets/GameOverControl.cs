using UnityEngine;
using System.Collections;

public class GameOverControl : MonoBehaviour {

	void Start () 
	{
		GameObject.Find("EndHighText GUI").GetComponent<GUIText>().text = "";
		GameObject.Find("EndHighText GUI2").GetComponent<GUIText>().text = "";
		GameObject.Find("EndHighScore GUI").GetComponent<GUIText>().text = "";
		GameObject.Find("EndText GUI").GetComponent<GUIText>().text = "";
		GameObject.Find("EndText GUI2").GetComponent<GUIText>().text = "";
		GameObject.Find("EndScore GUI").GetComponent<GUIText>().text = "";
		GameObject.Find("Km").GetComponent<GUIText>().text = "";
		GameObject.Find("ClistarScore").GetComponent<GUIText>().text = "";
		GameObject.Find("Retry").GetComponent<GUIText>().text = "";

	}
	
	void Update () {
	
	}
}
