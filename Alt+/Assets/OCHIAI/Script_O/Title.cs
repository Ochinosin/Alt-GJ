using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Title : MonoBehaviour {
	[SerializeField] private Image black;
	[SerializeField] private Animator anim;
	[SerializeField] private int col = 0;
	[SerializeField] private string StageTitle;
	public Scrollbar hp;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (col == 0) {
			if (Input.GetKeyDown (KeyCode.Return)) {
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
			black.color += new Color (0f, 0f, 0f, 0.02f);
			if(black.color.a >= 1f){
				black.color += new Color (0f, 0f, 0f, 1.0f);
				Application.LoadLevel (StageTitle);
			}
		}
	}
}
