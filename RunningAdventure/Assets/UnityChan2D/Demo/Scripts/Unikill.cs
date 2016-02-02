using UnityEngine;
using System.Collections;

public class Unikill : MonoBehaviour {
	public GameObject CrowPrefab;
	public static bool enemyjump = false;
	public static int jumpplan = 0;
	GameObject crow2;
	GameObject crow;
	// Use this for initialization
	void Start () {
		Move (transform.right * -1);
		for (int i = 0; i < 20; i++) {
			GameObject Crow = (GameObject)Instantiate(CrowPrefab);
			Vector3 p = Crow.transform.position;
			p.x = i * 20;
			Crow.transform.position = p;
			Move (transform.right * -1);
		}
	}

	public void Move (Vector2 direction) 
	{
		float rnd = Random.Range (-1.0f, 2.0f);
//		GameObject.Find ("Crow2").rigidbody2D.velocity = direction * 3;
		crow = GameObject.Find("Crow");
		crow.GetComponent<Rigidbody2D>().velocity = direction * 4;
		crow.transform.position = new Vector2(10.0f ,rnd);
		crow2 = GameObject.Find("Crow2");
		crow2.GetComponent<Rigidbody2D>().velocity = direction * 3;
		crow2.transform.position = new Vector2(10.0f ,rnd);
	}

	void OnTriggerStay2D(Collider2D other)
	{
		if (other.tag != "Player")return;

			if (gameObject.tag == "Unikill") {
					GameObject.Find ("Uni").GetComponent<Renderer>().enabled = false;
					GameObject.Find ("Uni").GetComponent<Collider2D>().enabled = false;		
		}
			if (gameObject.tag == "Unikill2") {
					GameObject.Find ("Unisi").GetComponent<Renderer>().enabled = false;
					GameObject.Find ("Unisi").GetComponent<Collider2D>().enabled = false;
		}
			if (gameObject.tag == "Unikill3") {
					GameObject.Find ("Crow").GetComponent<Renderer>().enabled = false;
					GameObject.Find ("Crow").GetComponent<Collider2D>().enabled = false;
		}
			if (gameObject.tag == "Unikill4"){
					GameObject.Find ("Crow2").GetComponent<Renderer>().enabled = false;
					GameObject.Find ("Crow2").GetComponent<Collider2D>().enabled = false;
				}
			
		enemyjump = true;
		jumpplan++; 
		Debug.Log ("enemyjump" + enemyjump);
	}
}