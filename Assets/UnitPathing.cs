using UnityEngine;
using System.Collections;

public class UnitPathing : MonoBehaviour {
    private Vector3[] pathPoints;
	public GeneratePath path;

    public float speed = 1;
    public int lastPathPoint = 0;
	private Vector3 lastPoint;
	private Vector3 nextPoint;
	private float distanceBetween;
    //0-1 how far along on the path between two points you are
    public float distAlong = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (pathPoints == null) {
			pathPoints = path.points;
			transform.position = pathPoints[lastPathPoint];
			lastPoint = pathPoints [lastPathPoint];
			nextPoint = pathPoints [lastPathPoint + 1];
			distanceBetween = Vector3.Distance (lastPoint, nextPoint);
		} else {
			float distanceToTravel = speed * Time.deltaTime; 

			while (distanceToTravel + distAlong > distanceBetween) {
				distanceToTravel -= distanceBetween - distAlong;
				lastPathPoint++;
				if (lastPathPoint == pathPoints.Length - 1) {
					lastPathPoint = 0;
				}
				lastPoint = pathPoints[lastPathPoint];
				nextPoint = pathPoints[lastPathPoint + 1];
				distanceBetween = getDistance (lastPoint, nextPoint);
				distAlong = 0;
			}
			distAlong += distanceToTravel;

			this.transform.position = (distAlong * nextPoint + (distanceBetween - distAlong) * lastPoint) / distanceBetween;
		}
	}

	private float getDistance(Vector3 v1, Vector3 v2){
		return Vector3.Distance (v1, v2);
	}
}
