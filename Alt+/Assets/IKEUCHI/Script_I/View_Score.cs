using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class View_Score : MonoBehaviour {
<<<<<<< HEAD
    /*
	private gameObject player;
	private bool gameover_flag=false; // ゲームオーバーフラグ
=======

	public Text t_time;
	public Text t_help; 
	public GameObject player;
	public bool gameover_flag=false; // ゲームオーバーフラグ
>>>>>>> 8a2025c367e9575ffedba40ba4001e9cd32714ca
	public Text t_score;
	public bool g_clear; // ゲームクリアしたか否か
	public int time;
	public int num;


	void Start () {
	
	}
	
	void Update () {
		if (gameover_flag)
			return;

		player_check ();
	}

	public void player_check(){
		
	}


	public void gameOver(){
		Destroy (t_help);
		Destroy (t_time); // 時間表示とお助け表示の削除
		int score;

		if (g_clear) { // ゲームクリア時は1000+残り時間*10
			score = 1000 + time*10;
		} else { // ゲームオーバー時は移動距離
			score = num; // 移動距離
		}

		// スコア表示ラベルに値を入れる
		t_score.text = "Score:\n" + score.ToString ();
	}

    */
}
