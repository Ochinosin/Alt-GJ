using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager_O : MonoBehaviour {
	public int state = 0;
	[SerializeField] private Image clear;
	[SerializeField] private Animator anim;
	[SerializeField] private string BoolName;
	[SerializeField] private Image over;
	[SerializeField] private Animator anim2;
	[SerializeField] private string BoolName2;
	[SerializeField] private GameObject start;
	[SerializeField] private Animator anim3;
	[SerializeField] private string BoolName3;
	[SerializeField] private Image player;
	[SerializeField] private Animator anim4;
	[SerializeField] private string BoolName4;
	[SerializeField] private Text time;
	[SerializeField] private Text help;
	[SerializeField] private bool endSart;
	[SerializeField] private string TopTitle;
	[SerializeField] private Image black;
	[SerializeField] private int col;
	[SerializeField] private AudioSource BGM;
	[SerializeField] private AudioSource SE;
	[SerializeField] private AudioClip gameOver;
	[SerializeField] private AudioClip gameClear;

	public GameObject Player;
	public GameObject Camera;
	public GameObject Canvas;
	private bool OV;
	private bool CL;

	// Use this for initialization
	void Start () {
		anim3.SetBool (BoolName3, true);
	}
	
	// Update is called once per frame
	void Update () {
		/*if (Input.GetKeyDown (KeyCode.Space)) {
			state = 1;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			state = 2;
		}*/
		if (state == 0) {
			BGM.volume += 0.002f;
			if (BGM.volume >= 0.2f) {
				BGM.volume = 0.2f;
			}
		}

		if (state == 1) {
			BGM.volume = 0.0f;
			if (CL == false) {
				SE.PlayOneShot (gameClear);
				CL = true;
			}
			anim4.SetBool ("Pstop", true);
			Player.GetComponent<Player_O> ().enabled = false;
			//Camera.GetComponent<Camera_O> ().enabled = false;
			clear.enabled = true;
			over.enabled = false;
			GetComponent<GUICtrl_O> ().enabled = false;
			anim.SetBool (BoolName, true);
			if (Input.GetKeyDown (KeyCode.Return)) {
				col = 1;
			}
		}
		if (state == 2) {
			BGM.volume = 0.0f;
			anim4.SetBool ("Pstop", true);
			Player.GetComponent<Player_O> ().enabled = false;
			//Camera.GetComponent<Camera_O> ().enabled = false;
			time.enabled = false;
			help.enabled = false;
			clear.enabled = false;
			over.enabled = true;
			anim2.SetBool (BoolName2, true);
			if (Input.GetKeyDown (KeyCode.Return)) {
				col = 1;
			}
		}
		if (col == 0) {
			black.color -= new Color (0f, 0f, 0f, 0.02f);
			if(black.color.a <= 0f){
				black.color += new Color (0f, 0f, 0f, 0.0f);
			}
		}
		if (col == 1) {
			anim.speed = 0;
			black.color += new Color (0f, 0f, 0f, 0.02f);
			if(black.color.a >= 1f){
				black.color += new Color (0f, 0f, 0f, 1.0f);
				Application.LoadLevel (TopTitle);
			}
		}

		if (Canvas.GetComponent<GUICtrl_O> ().time <= 1) {
			if (OV == false) {
				SE.PlayOneShot (gameOver);
				OV = true;
			}
			state = 2;
		}

		if (endSart == false) {
			AnimatorStateInfo animInfo;
			animInfo = start.GetComponent<Animator> ().GetCurrentAnimatorStateInfo (0);
			if (animInfo.normalizedTime >= 1.0f) {
				Player.GetComponent<Player_O> ().enabled = true;
				//Camera.GetComponent<Camera_O> ().enabled = true;
				anim4.SetBool (BoolName4, true);
				time.enabled = true;
				help.enabled = true;
				GetComponent<GUICtrl_O> ().enabled = true;
				endSart = true;
			}
		}
	}
}
