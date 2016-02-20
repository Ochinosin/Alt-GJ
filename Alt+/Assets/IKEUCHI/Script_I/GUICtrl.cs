using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GUICtrl : MonoBehaviour {

	public Slider hp;
	public Text timeGUI;
	public Text helpGUI;
	private float time = 13f;
	private bool help; //お助け可能かどうか


	void Start () {
		hp.value=100;
		timeGUI.text = time.ToString ();
	}

	void Update () {

		if(time<10f) help = true; // お助け判定関数ができたら変更

		// helpの値によってお助け可か判定
		if (help) {
			helpGUI.color = Color.red;
			helpGUI.text = "お助け\n可能!";
		} else {
			helpGUI.color = Color.green;
			helpGUI.text = "お助け\n準備中";
		}

//		hp.value--; // プレイヤーobjできたら変更

		if (time < 10f) {
			timeGUI.color = Color.red;
			float alpha = timeGUI.color.a;
			if (alpha == 1.0f)
				timeGUI.color = new Color (timeGUI.color.r, timeGUI.color.g, timeGUI.color.b, 0.0f);
			else
				timeGUI.color = new Color (timeGUI.color.r, timeGUI.color.g, timeGUI.color.b, 1.0f);
		}

		// 残り時間表示
		if(time>0) time-=1f*Time.deltaTime;
		timeGUI.text = "Time:"+((int)time).ToString ()+"sec";	
	}



}
