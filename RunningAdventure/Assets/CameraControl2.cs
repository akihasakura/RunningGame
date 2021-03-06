﻿using UnityEngine;
using System.Collections;

public class CameraControl2 : MonoBehaviour {

	// プレイヤー.
	private GameObject	player = null;
	
	public Vector3		offset;

	//最初のカメラの位置
	public Vector3		homePosition;

	//ボーナスステージにいる時間をカウントする値
	private int bonustart = 0;

	//ボーナスステージにいる時間
	public int bonusrage = 200;

	public static bool bonusinv = false;

	public Animator animator;
	
	void Start () {
		
		// プレイヤーのインスタンスを探しておく.
		this.player = GameObject.FindGameObjectWithTag("Player");
		
		this.offset = this.transform.position - this.player.transform.position;

		this.homePosition = this.transform.position;
	}
	
	void Update () {
		//ボーナスステージの終わり
		if(bonustart > bonusrage)
		{
			bonustart = 0;
			UnityChan2DController.bonusflg = false;
			UnityChan2DController.jumpconstraint = 0;
			UnityChan2DController.bonusJump = 0;
			FindObjectOfType<FeverGaugeControl>().init();
			bonusinv = true;

		}

		if(StopControl.is_playing == true && UnityChan2DController.bonusflg == true)
		{
			bonustart++;
		}

		//ボーナスステージ中ならカメラを上に移す
		if(UnityChan2DController.bonusflg == true)
		{
		
			//print("bonustart"+bonustart);

			this.transform.position = new Vector3(player.transform.position.x + this.offset.x, this.homePosition.y + 11, this.transform.position.z);

			//animator.SetBool("LightStop", true);
		}

		else
		{
		// プレイヤーと一緒に移動.
			this.transform.position = new Vector3(player.transform.position.x + this.offset.x, this.homePosition.y, this.transform.position.z);

			//animator.SetBool("LightStop", false);
		}

		BackGround (UnityChan2DController.bonusflg);
		Debug.Log ("bonusflg "+UnityChan2DController.bonusflg);

	}

	public void BackGround(bool BF)
	{
		GameObject.Find("bg_normal").GetComponent<Renderer>().enabled  = !BF;
		GameObject.Find("mountain1").GetComponent<Renderer>().enabled  = !BF;
		GameObject.Find("mountain2").GetComponent<Renderer>().enabled  = !BF;
		GameObject.Find("bg_fever").GetComponent<Renderer>().enabled  = BF;
		GameObject.Find("lighthouse").GetComponent<Renderer>().enabled  = BF;
		Debug.Log ("!BF "+ !BF + BF);
	}
}
