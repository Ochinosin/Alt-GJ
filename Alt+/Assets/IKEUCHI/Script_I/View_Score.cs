using UnityEngine;
using System.Collections;

public class View_Score : MonoBehaviour {

	private gameObject player;
	private bool gameover_flag=false; // ゲームオーバーフラグ
	public Text t_score;
	public int score;
	public bool g_clear; // ゲームクリアしたか否か

	public GameObject

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
		Destroy (); // 時間表示とお助け表示の削除
		if (g_clear) { // ゲームクリア時は1000+残り時間*10
			score = 1000 + time*10;
		} else { // ゲームオーバー時は移動距離
			score = num; // 移動距離
		}

		// スコア表示ラベルに値を入れる
		t_score.text = "Score:\n" + score.ToString ();
	}


}
