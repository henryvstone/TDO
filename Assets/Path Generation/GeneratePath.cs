using UnityEngine;
using System.Collections;

public class GeneratePath : MonoBehaviour {
	public GameObject[] nodes;
	public GameObject roadSprite;

	// Use this for initialization
	void Start () {

		// Stretches each path sprite between nodes
		for(int i = 1; i < nodes.Length; i++) {
			GameObject pathSection = Instantiate(roadSprite);

			Vector3 currentPos = nodes[i].transform.position;
			Vector3 previousPos = nodes[i-1].transform.position;

			Vector3 direction = currentPos - previousPos;
			direction.Normalize();
			pathSection.transform.right = direction;

			Vector3 centerPos = (currentPos + previousPos) / 2;
			pathSection.transform.position = centerPos;

			float distance = Vector3.Distance(currentPos, previousPos);
			pathSection.transform.localScale = new Vector3(2 * distance, 1, 1);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
