using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public float maxHealth = 100f;
	public float currentHealth = 0f;
	public GameObject healthBar;

	// Use this for initialization
	void Start () {
		currentHealth = maxHealth;
		InvokeRepeating ("decreaseHealth", 1f, 1f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void decreaseHealth() {
		currentHealth -= 2f;
		float calculatedHealth = currentHealth / maxHealth;
		setHealthBar (calculatedHealth);
	}

	public void setHealthBar(float newHealth) {
		// health is a value between 0 and 1
		if (newHealth >= 0 && newHealth < 1) {
			healthBar.transform.localScale = new Vector3 (newHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
		}
	}
}
