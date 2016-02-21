﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class View_Score : MonoBehaviour {

	public Text t_time;
	public Text t_help; 
	public GameObject player;
	public bool gameover_flag=false; // ゲームオーバーフラグ
	public Text t_score;

	public bool g_finish; // ゲームが終了したか否か
	public bool g_clear; // ゲームクリアしたか否か

	public float time;
	public int num;


	void Start () {
	}
	
	void Update () {
		if (gameover_flag)
			return;

		player_check ();
	}

	void player_check(){
		if(g_finish)
		gameOver ();
	}


	void gameOver(){
		Destroy (t_help);
		Destroy (t_time); // 時間表示とお助け表示の削除

		int score;

		if (g_clear) { // ゲームクリア時は1000+残り時間*10
			score = 1000 + (int)time*10;
		} else { // ゲームオーバー時は移動距離
			score = num; // 移動距離(最初と最後のx座標の差)
		}

		// スコア表示ラベルに値を入れる
		t_score.text = "Score:\n" + score.ToString ();

		gameover_flag = true;
	}

	void set_score(){

	}

}
