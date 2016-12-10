using UnityEngine;
using System.Collections;

public class UnitBehavior : MonoBehaviour {
	public float maxHealth = 100;
	private float health = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		Debug.Log(this.health);
	}

	public float getHealth() {
		return this.health;
	}

	public void setHealth(float health) {
		this.health = health;
	}
}
