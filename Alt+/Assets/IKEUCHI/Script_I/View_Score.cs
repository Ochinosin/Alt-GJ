using UnityEngine;
using System.Collections;

public class View_Score : MonoBehaviour {

	private GameObject player;
	private bool gameover_flag=false; // ゲームオーバーフラグ
	public string t_score;
	public int score;
	public bool g_clear; // ゲームクリアしたか否か
	float time;
	int num;

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
		Destroy (gameObject); // 時間表示とお助け表示の削除
		if (g_clear) { // ゲームクリア時は1000+残り時間*10
			score = 1000 + (int)time*10;
		} else { // ゲームオーバー時は移動距離
			score = num; // 移動距離
		}

		// スコア表示ラベルに値を入れる
		t_score = "Score:\n" + score.ToString ();
	}


}
