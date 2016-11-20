using UnityEngine;
using System.Collections;

public class UnitPathing : MonoBehaviour {
    public Vector3[] pathPoints;
    public double speed;

    public int lastPathPoint = 0;
    //0-1 how far along on the path between two points you are
    public double dist = 0;

	// Use this for initialization
	void Start () {
        transform.position = pathPoints[lastPathPoint];
	}
	
	// Update is called once per frame
	void Update () {
        double distanceToTravel = speed * Time.deltaTime; 
        Vector3 lastPoint = pathPoints[lastPathPoint];
        Vector3 nextPoint = pathPoints[lastPathPoint + 1];
	}
}
