using UnityEngine;
using System.Collections;

public class DimplesScript : MonoBehaviour {
	public Transform target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		bool leftPunch = Input.GetKey (KeyCode.Y);
		bool rightPunch = Input.GetKey (KeyCode.U);
		bool death = Input.GetKey (KeyCode.P);
		bool getHit1 = Input.GetKey (KeyCode.O);
		bool getHit2 = Input.GetKey (KeyCode.M);

		if (leftPunch) {
			this.GetComponent<Animator> ().SetTrigger ("punchL");
		}

		if (rightPunch) {
			this.GetComponent<Animator> ().SetTrigger ("punchR");
		}

		if (death) {
			this.GetComponent<Animator> ().SetTrigger ("death");
		}

		if (getHit1) {
			this.GetComponent<Animator> ().SetTrigger ("gethit");
		}

		if (getHit2) {
			this.GetComponent<Animator> ().SetTrigger ("gethit2");
		}
	}
}
