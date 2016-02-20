using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameManager_O : MonoBehaviour {
	[SerializeField] private int state = 0;
	[SerializeField] private Image clear;
	[SerializeField] private Animator anim;
	[SerializeField] private string BoolName;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			state = 1;
		}
		if (state == 1) {
			clear.enabled = true;
			anim.SetBool (BoolName, true);
		}
	}
}
