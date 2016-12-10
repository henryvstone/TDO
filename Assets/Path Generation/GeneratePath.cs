using UnityEngine;
using System.Collections;

public class GeneratePath : MonoBehaviour {
	public GameObject[] nodes;
	public GameObject roadSprite;

	public Vector3[] points;



	// Use this for initialization
	void Start () {

		points = new Vector3[nodes.Length];
		points [0] = nodes [0].transform.position;
		// Stretches each path sprite between nodes
		for(int i = 1; i < nodes.Length; i++) {
			points [i] = nodes [i].transform.position;
			GameObject pathSection = Instantiate(roadSprite);
			pathSection.transform.parent = this.transform;

			Vector3 currentPos = nodes[i].transform.position;
			Vector3 previousPos = nodes[i-1].transform.position;

			Vector3 direction = currentPos - previousPos;
			direction.Normalize();
			pathSection.transform.right = direction;

			Vector3 centerPos = (currentPos + previousPos) / 2;
			pathSection.transform.position = centerPos;

			float distance = Vector3.Distance(currentPos, previousPos);
			pathSection.transform.localScale = new Vector3(distance, 1, 1);

			DestroyObject (nodes [i]);
		}

		DestroyObject (nodes [0]);
	}
		
	// Update is called once per frame
	void Update () {

	}
}
