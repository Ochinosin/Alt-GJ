using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager_O : MonoBehaviour {
	[SerializeField] private int state = 0;
	[SerializeField] private Image clear;
	[SerializeField] private Animator anim;
	[SerializeField] private string BoolName;
	[SerializeField] private Image over;
	[SerializeField] private Animator anim2;
	[SerializeField] private string BoolName2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			state = 1;
		}
		if (Input.GetKeyDown (KeyCode.A)) {
			state = 2;
		}
		if (state == 1) {
			clear.enabled = true;
			anim.SetBool (BoolName, true);
		}
		if (state == 2) {
			over.enabled = true;
			anim2.SetBool (BoolName2, true);
		}
	}
}
