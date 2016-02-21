using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUICtrl_O : MonoBehaviour {
	public Slider hp;
	public Text timeGUI;
	public Text helpGUI;
	public Text scoreGUI;
	public float time = 13f;
	public float interval=0.5f;
	private float nextTime;
	private bool help; //お助け可能かどうか
	private bool use_help; // お助け発動中
	private int score=0;
	private float s_x;
	private float g_x;
	[SerializeField] private AudioSource SE;
	[SerializeField] private AudioClip keikoku;

	private bool kei;

	void Start () {
		//		hp.value=100;
		timeGUI.text = time.ToString ();
		s_x = 20f; // 開始座標を取得	
	}

	void Update () {

		//		score = g_x - s_x; // 現在座標と開始座標の差をぶっこむ
				score+=(int)s_x;

		scoreGUI.text = "Score:" + score.ToString ();

		if(time<10f) help = true; // 助っ人使用可の場合
		if(time<7.0f) use_help=true; // 助っ人使用時

		// helpの値によってお助け可か判定
		if (help) {
			helpGUI.color = Color.blue;
			helpGUI.text = "助っ人\n準備OK！";
		} else {
			helpGUI.text = "";
		}

		// お助け使用時
		if (use_help) {
			helpGUI.color = Color.yellow;
			helpGUI.text = "助っ人\n参上\\(^o^)/";
		}


		//		hp.value--; // プレイヤーobjできたら変更

		if (time < 10f && time > 0) {
			if (kei == false) {
				SE.PlayOneShot (keikoku);
				kei = true;
			}
			SE.PlayOneShot (keikoku);
			if (Time.time > nextTime) {

				float alpha = timeGUI.color.a;
				if (alpha == 1.0f) {
					timeGUI.color = Color.red; // ここで色指定しないとalphaがおかしくなる
					timeGUI.color = new Color (timeGUI.color.r, timeGUI.color.g, timeGUI.color.b, 0.0f);			
				} else {
					timeGUI.color = new Color (timeGUI.color.r, timeGUI.color.g, timeGUI.color.b, 1.0f);
				}

				if (time < 6f)
					interval = 0.2f; // 残り5秒で更に早くなる

				nextTime += interval;
			}

		} else {
			nextTime = Time.time;
		}

		if(time>0) time-=1f*Time.deltaTime;
		timeGUI.text = "配膳まで残り:"+((int)time).ToString ()+"秒";
	}
}
