using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {

	public float damage = 10f;
	public float range = 20f;
	public float fireRate = 1f;
	public GameObject units;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		foreach (Transform child in units.transform) {
			float distance = (child.position - this.transform.position).magnitude;
			if (distance < this.range) {
				UnitBehavior unit = child.GetComponent<UnitBehavior>();
				unit.setHealth(unit.getHealth() - this.damage);
			}
		}
	}
}
