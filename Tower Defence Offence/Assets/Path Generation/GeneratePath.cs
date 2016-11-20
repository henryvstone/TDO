using UnityEngine;
using System.Collections;

public class GeneratePath : MonoBehaviour {
    public GameObject[] nodes;
    public GameObject thingyToConnect;

	// Use this for initialization
	void Start () {
        for(int i = 1; i < nodes.Length; i++)
        {
            GameObject created = Instantiate(thingyToConnect);
            created.transform.position = nodes[i].transform.position;
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
