using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Title : MonoBehaviour {
	[SerializeField] private Image black;
	[SerializeField] private Animator anim;
	[SerializeField] private int col = 0;
	[SerializeField] private string StageTitle;
	[SerializeField] private AudioSource Tyaimu;
	[SerializeField] private AudioSource Zawazawa;
	[SerializeField] private float time;
	[SerializeField] private AudioSource SE;
	[SerializeField] private AudioClip enter;
	[SerializeField] private Animator anim2;
	[SerializeField] private string BoolName;

	// Use this for initialization
	void Start () {
		time = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (col == 0) {
			time += Time.deltaTime;
			if (time >= 20.0f) {
				Tyaimu.volume -= 0.0025f;
				Zawazawa.volume -= 0.0025f;
			}
			if (Input.GetKeyDown (KeyCode.Return)) {
				SE.PlayOneShot (enter);
				anim2.SetBool (BoolName, true);
				col = 1;
			}
		}
		/*if (col == 1) {
			if (Input.GetKeyDown (KeyCode.Return)) {
				col = 2;
			}
		}*/
		if (col == 1) {
			anim.speed = 0;
			Tyaimu.volume -= 0.01f;
			Zawazawa.volume -= 0.01f;
			black.color += new Color (0f, 0f, 0f, 0.01f);
			if(black.color.a >= 1f){
				black.color += new Color (0f, 0f, 0f, 1.0f);
				Application.LoadLevel (StageTitle);
			}
		}
	}
}
